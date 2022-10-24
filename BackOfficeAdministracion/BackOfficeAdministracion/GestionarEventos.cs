using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public partial class GestionarEventos : Form
    {
        public GestionarEventos()
        {
            InitializeComponent();
        }
        public static EncuentrosColectivos encuentrosColectivos = new EncuentrosColectivos();
        

        private void GestionarEventos_Load(object sender, EventArgs e)
        {
            this.refrescarEquiposEnSistema();
        }
        private void cerrar()
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Program.frmIncidencias.StartPosition = FormStartPosition.CenterScreen;
            Program.frmIncidencias.TopMost = true;
            Program.frmIncidencias.Visible = true;
            Program.frmPrincipal.Enabled = false;
        }

        private void btnIncidenciasIndividuales_Click(object sender, EventArgs e)
        {
            Program.frmIncidenciasIndividuales.StartPosition = FormStartPosition.CenterScreen;
            Program.frmIncidenciasIndividuales.TopMost = true;
            Program.frmIncidenciasIndividuales.Visible = true;
            Program.frmPrincipal.Enabled = false;
        }

        private void btnAlineacion_Click(object sender, EventArgs e)
        {
            Program.frmAlineacion.StartPosition = FormStartPosition.CenterScreen;
            Program.frmAlineacion.Visible = true;
            Program.frmAlineacion.TopMost = true;
            Program.frmPrincipal.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescarEncuentrosIndividuales_Click(object sender, EventArgs e)
        {

        }
        private void refrescarEventosColectivos() {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreEncuentros(lista))
            {
                case 0:
                    cmboxIDEvento.Items.Clear();
                    cmboxIDEvento.Text = null;
                    cmboxIDEvento.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxIDEvento.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes    -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          cargados");
                    break;
            }
        }
        private void btnRefrescarEncuentroColectivo_Click(object sender, EventArgs e)
        {
            this.refrescarEventosColectivos();
            this.refrescarEquiposEnSistema();
        }       

        private void refrescarEquiposEnSistema()
        {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreEquipos(lista))
            {
                case 0:
                    cmboxEquiposenSistema.Items.Clear();
                    cmboxEquiposenSistema.Text = null;
                    cmboxEquiposenSistema.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxEquiposenSistema.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen equipos en el sistema");
                    break;
            }
        }
        private void refrescarEquiposEnEncuentro()
        {
            int idEncuentroCole = Convert.ToInt32(txtIDencuentroCole.Text);
            List<string> lista = new List<string>();
            switch (Logica.EquiposEncuentrosColectivos(idEncuentroCole, lista))
            {
                case 0:
                    cmboxEquiposenEncuentro.Items.Clear();
                    cmboxEquiposenEncuentro.Text = "";
                        cmboxEquiposenEncuentro.Text = lista[0];
                        foreach (string nombre in lista)
                        {
                            cmboxEquiposenEncuentro.Items.Add(nombre);
                        }
                    
                    
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen equipos en el encuentro");
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                encuentrosColectivos.idEncuentro = Convert.ToInt32(cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3)));
                List<string> equiposEncuentro = new List<string>();
                switch (Logica.DatosEncuentrosColectivos(encuentrosColectivos, equiposEncuentro)) {
                    case 0:
                        txtDescripcionCole.Text = encuentrosColectivos.descripcion;
                        txtIDencuentroCole.Text = encuentrosColectivos.idEncuentro.ToString();
                        dtimeFechaComienza.Text = encuentrosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = encuentrosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = encuentrosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = encuentrosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = encuentrosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = encuentrosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Text = encuentrosColectivos.deporteEncuentro;
                        cmboxEquiposenEncuentro.Items.Clear();
                        cmboxEquiposenEncuentro.Text = equiposEncuentro[0];
                        foreach (string nombre in equiposEncuentro)
                        {
                            cmboxEquiposenEncuentro.Items.Add(nombre);
                        }                 
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("Evento no econtrado, desea crearlo?");
                        break;
                    case 4:
                        MessageBox.Show("El encuentro no está asociado a un deporte");
                        cmboxDeportes.Text = null;
                        txtDescripcionCole.Text = encuentrosColectivos.descripcion;
                        txtIDencuentroCole.Text = encuentrosColectivos.idEncuentro.ToString();
                        dtimeFechaComienza.Text = encuentrosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = encuentrosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = encuentrosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = encuentrosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = encuentrosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = encuentrosColectivos.fechaFinaliza.Minute.ToString();
                        this.refrescarEquiposEnEncuentro();
                        break;
                    case 5:
                        MessageBox.Show("El encuentro no tiene equipos");
                        cmboxEquiposenEncuentro.Items.Clear();
                        cmboxEquiposenEncuentro.Text = null;
                        txtDescripcionCole.Text = encuentrosColectivos.descripcion;
                        txtIDencuentroCole.Text = encuentrosColectivos.idEncuentro.ToString();
                        dtimeFechaComienza.Text = encuentrosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = encuentrosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = encuentrosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = encuentrosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = encuentrosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = encuentrosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Text = encuentrosColectivos.deporteEncuentro;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("ID no es valido. El formato debe ser:\nID:<IDencuentro> <NombreEncuentro>");
            }
        }

        private void btnQuitarEncuentroCole_Click(object sender, EventArgs e)
        {
            int idEncuentro = Convert.ToInt32(txtIDencuentroCole.Text);
            string nombre = cmboxEquiposenEncuentro.Text.Substring(0, cmboxEquiposenEncuentro.Text.IndexOf("/"));
            string categoria = cmboxEquiposenEncuentro.Text.Substring((cmboxEquiposenEncuentro.Text.IndexOf("/") + 1), (cmboxEquiposenEncuentro.Text.Length - (cmboxEquiposenEncuentro.Text.IndexOf("/") + 1)));
            switch (Logica.quitarEquipoEncuentroColectivo(nombre, categoria, idEncuentro)) {
                case 0:
                    MessageBox.Show("Equipo desvinculado exitosamente");
                    this.refrescarEquiposEnEncuentro();
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
            }

        }

        private void btnAgregarAlEncuentroCole_Click(object sender, EventArgs e)
        {
            int idEncuentro = Convert.ToInt32(txtIDencuentroCole.Text);
            string nombre = cmboxEquiposenSistema.Text.Substring(0, cmboxEquiposenSistema.Text.IndexOf("/"));
            string categoria = cmboxEquiposenSistema.Text.Substring((cmboxEquiposenSistema.Text.IndexOf("/") + 1), (cmboxEquiposenSistema.Text.Length - (cmboxEquiposenSistema.Text.IndexOf("/") + 1)));
            switch (Logica.AgregarEquipoEncuentroColectivo(nombre, categoria, idEncuentro))
            {
                case 0:
                    this.refrescarEquiposEnEncuentro();
                    MessageBox.Show("Equipo agregado exitosamente");
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado. Las causas pueden ser: \n      El equipo se encuentra en este evento \n      Ya participa en otro evento a la misma fecha y hora");
                    break;
                case 3:
                    MessageBox.Show("El equipo no tiene jugadores, no será agregado al evento");
                    break;
            }
        }
    }
}
