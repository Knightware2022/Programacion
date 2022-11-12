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

        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {
            this.BackColor = fondo;
            tbpgModificar.BackColor = fondo;
            paneBotones.BackColor = fondo;
            paneDatosEvento.BackColor = fondo;
            paneEquipos.BackColor = fondo;
            paneModificarEvento.BackColor = fondo;

            tbcGestionarEventos.BackColor = fondo;
            lblIDmodificar.ForeColor = letra;
            btnBuscar.BackColor = boton;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = boton;
            btnBuscar.ForeColor = letra;
            btnRefrescarEncuentroColectivo.BackColor = boton;
            btnRefrescarEncuentroColectivo.FlatStyle = FlatStyle.Flat;
            btnRefrescarEncuentroColectivo.FlatAppearance.BorderColor = boton;
            btnRefrescarEncuentroColectivo.ForeColor = letra;
            lblIDEncuentroCole.ForeColor = letra;
            lblDeporte.ForeColor = letra;
            lblEquiposenSistema.ForeColor = letra;
            lblEquiposenEncuentro.ForeColor = letra;
            btnAgregarAlEncuentroCole.BackColor = boton;
            btnAgregarAlEncuentroCole.FlatStyle = FlatStyle.Flat;
            btnAgregarAlEncuentroCole.FlatAppearance.BorderColor = boton;
            btnAgregarAlEncuentroCole.ForeColor = letra;
            btnQuitarEncuentroCole.BackColor = boton;
            btnQuitarEncuentroCole.FlatStyle = FlatStyle.Flat;
            btnQuitarEncuentroCole.FlatAppearance.BorderColor = boton;
            btnQuitarEncuentroCole.ForeColor = letra;
            lblFechaComienzo.ForeColor = letra;
            lblHoraComienzo.ForeColor = letra;
            lblHoraComienza.ForeColor = letra;
            lblMinutosComienza.ForeColor = letra;
            lblFechaFinalizaCole.ForeColor = letra;
            lblHoraFinalizaColec.ForeColor = letra;
            lblFinalizaColectivo.ForeColor = letra;
            lblMinutoFinCole.ForeColor = letra;
            lblDescripcionColect.ForeColor = letra;
            btnIncidencias.BackColor = boton;
            btnIncidencias.FlatStyle = FlatStyle.Flat;
            btnIncidencias.FlatAppearance.BorderColor = boton;
            btnIncidencias.ForeColor = letra;
            btnAlineacion.BackColor = boton;
            btnAlineacion.FlatStyle = FlatStyle.Flat;
            btnAlineacion.FlatAppearance.BorderColor = boton;
            btnAlineacion.ForeColor = letra;
            btnAceptar.BackColor = boton;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = boton;
            btnAceptar.ForeColor = letra;
            btnCancelar.BackColor = boton;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderColor = boton;
            btnCancelar.ForeColor = letra;
            btnEliminar.BackColor = boton;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderColor = boton;
            btnEliminar.ForeColor = letra;
            btnCerrar.BackColor = boton;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderColor = boton;
            btnCerrar.ForeColor = letra;
            btnCrearEventoColectivo.BackColor = boton;
            btnCrearEventoColectivo.FlatStyle = FlatStyle.Flat;
            btnCrearEventoColectivo.FlatAppearance.BorderColor = boton;
            btnCrearEventoColectivo.ForeColor = letra;
        }
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
            Program.frmIncidencias.refrescarEquiposCargados();
        }

        private void btnAlineacion_Click(object sender, EventArgs e)
        {
            Program.frmAlineacion.StartPosition = FormStartPosition.CenterScreen;
            Program.frmPrincipal.Enabled = false;
            Program.frmAlineacion.Visible = true;
            Program.frmAlineacion.TopMost = true;
            Program.frmAlineacion.refrescarEquiposCargados();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            encuentrosColectivos.idEncuentro = Convert.ToInt32(cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3)));
            encuentrosColectivos.descripcion = txtDescripcionCole.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;
            encuentrosColectivos.nombreDeporte = cmboxDeportes.Text;
            fechaComienzo = dtimeFechaComienza.Text + " " + cmboxHoraComienzo.Text + ":" + cmboxMinutos.Text + ":00";
            encuentrosColectivos.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinaliza.Text + " " + cmboxHoraFinCole.Text + ":" + cmboxMinutoFinCole.Text + ":00";
            encuentrosColectivos.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = encuentrosColectivos.fechaComienzo.Year + "-" + encuentrosColectivos.fechaComienzo.Month + "-" + encuentrosColectivos.fechaComienzo.Day + " " + encuentrosColectivos.fechaComienzo.TimeOfDay; 
            fechaF = encuentrosColectivos.fechaFinaliza.Year + "-" + encuentrosColectivos.fechaFinaliza.Month + "-" + encuentrosColectivos.fechaFinaliza.Day +" " + encuentrosColectivos.fechaFinaliza.TimeOfDay;

            switch (Logica.ActualizarEventoColectivo(encuentrosColectivos, fechaC, fechaF))
            {
                case 0:
                    this.refrescarEventosColectivos();
                    MessageBox.Show(Idiomas.eventoActualizado);
                    paneModificarEvento.Enabled = true;
                    paneDatosEvento.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCrearEventoColectivo.Enabled = false;
                    txtDescripcionCole.Text = null;
                    txtIDencuentroCole.Text = null;
                    cmboxMinutoFinCole.Text = "00";
                    cmboxHoraComienzo.Text = "00";
                    cmboxMinutos.Text = "00";
                    cmboxHoraFinCole.Text = "00";

                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
            }
        }

        private void refrescarEventosColectivos()
        {
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:

                    MessageBox.Show(Idiomas.noEventoSistema);
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.noequiposSistema);
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.EventosNOTIENEequipos);
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int id = 0;
            if (int.TryParse(cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3)), out id)){
                encuentrosColectivos.idEncuentro = id;

                List<string> equiposEncuentro = new List<string>();
                switch (Logica.DatosEncuentrosColectivos(encuentrosColectivos, equiposEncuentro))
                {
                    case 0:
                        paneDatosEvento.Enabled = true;
                        paneModificarEvento.Enabled = false;
                        btnAceptar.Enabled = true;
                        btnCrearEventoColectivo.Enabled = false;
                        btnEliminar.Enabled = true;
                        btnAlineacion.Enabled = true;
                        btnIncidencias.Enabled = true;
                        txtDescripcionCole.Text = encuentrosColectivos.descripcion;
                        txtIDencuentroCole.Text = encuentrosColectivos.idEncuentro.ToString();
                        dtimeFechaComienza.Text = encuentrosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = encuentrosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = encuentrosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = encuentrosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = encuentrosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = encuentrosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Items.Clear();
                        cmboxDeportes.Items.Add(encuentrosColectivos.nombreDeporte);
                        cmboxDeportes.Text = encuentrosColectivos.nombreDeporte;
                        paneEquipos.Enabled = true;
                        cmboxEquiposenEncuentro.Items.Clear();
                        foreach (string nombre in equiposEncuentro)
                        {
                            cmboxEquiposenEncuentro.Items.Add(nombre);
                        }
                        cmboxEquiposenEncuentro.Text = equiposEncuentro[0];

                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                    case 3:
                        DialogResult crearUsuario = MessageBox.Show(Idiomas.crearEvento, Idiomas.crearEventotitulo, MessageBoxButtons.YesNo);
                        if (crearUsuario == DialogResult.Yes)
                        {
                            
                            List<string> nombresDepo = new List<string>();
                            switch (Logica.nombresDeportes(nombresDepo)){
                                case 0:
                                    foreach (string nombre in nombresDepo) {
                                        cmboxDeportes.Items.Add(nombre);
                                    }
                                    cmboxDeportes.Text = nombresDepo[0];
                                    break;

                                case 1: case 2:
                                    MessageBox.Show(Idiomas.noDeportesSistema);
                                    break;

                            }
                            txtDescripcionCole.Text = cmboxIDEvento.Text.Substring(cmboxIDEvento.Text.IndexOf("-") + 1);
                            txtIDencuentroCole.Text = cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3));
                            cmboxIDEvento.Text = null;
                            paneModificarEvento.Enabled = false;
                            paneDatosEvento.Enabled = true;

                            btnAlineacion.Enabled = false;
                            btnIncidencias.Enabled = false;
                            btnAceptar.Enabled = false;
                            btnEliminar.Enabled = false;
                            btnCrearEventoColectivo.Enabled = true;
                            paneEquipos.Enabled = false;
                        }
                        else
                        {

                        }
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
                        paneDatosEvento.Enabled = true;
                        paneModificarEvento.Enabled = false;
                        btnAceptar.Enabled = true;
                        btnCrearEventoColectivo.Enabled = false;
                        btnEliminar.Enabled = true;
                        btnAlineacion.Enabled = true;
                        btnIncidencias.Enabled = true;
                        this.refrescarEquiposEnEncuentro();
                        break;
                    case 5:
                        MessageBox.Show(Idiomas.EventosNOTIENEequipos);
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
                        cmboxDeportes.Items.Clear();
                        cmboxDeportes.Items.Add(encuentrosColectivos.nombreDeporte);
                        cmboxDeportes.Text = encuentrosColectivos.nombreDeporte;
                        paneDatosEvento.Enabled = true;
                        paneModificarEvento.Enabled = false;
                        btnAceptar.Enabled = true;
                        btnCrearEventoColectivo.Enabled = false;
                        btnEliminar.Enabled = true;
                        btnAlineacion.Enabled = true;
                        btnIncidencias.Enabled = true;
                        break;
                }
            }         
            else
            {
                MessageBox.Show("ID no es valido. El formato debe ser:\nID:<IDencuentro> <NombreEncuentro>");
            }
        }

        private void btnQuitarEncuentroCole_Click(object sender, EventArgs e)
        {
            int idEncuentro = Convert.ToInt32(txtIDencuentroCole.Text);
            string nombre = cmboxEquiposenEncuentro.Text.Substring(0, cmboxEquiposenEncuentro.Text.IndexOf("/"));
            string categoria = cmboxEquiposenEncuentro.Text.Substring((cmboxEquiposenEncuentro.Text.IndexOf("/") + 1), (cmboxEquiposenEncuentro.Text.Length - (cmboxEquiposenEncuentro.Text.IndexOf("/") + 1)));
            switch (Logica.quitarEquipoEncuentroColectivo(nombre, categoria, idEncuentro, encuentrosColectivos.deporteEncuentro))
            {
                case 0:
                    MessageBox.Show(Idiomas.equipoDesvinculadoEvento);
                    this.refrescarEquiposEnEncuentro();
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }

        }

        private void btnAgregarAlEncuentroCole_Click(object sender, EventArgs e)
        {
            int idEncuentro = Convert.ToInt32(txtIDencuentroCole.Text);
            string nombre = cmboxEquiposenSistema.Text.Substring(0, cmboxEquiposenSistema.Text.IndexOf("/"));
            string categoria = cmboxEquiposenSistema.Text.Substring((cmboxEquiposenSistema.Text.IndexOf("/") + 1), (cmboxEquiposenSistema.Text.Length - (cmboxEquiposenSistema.Text.IndexOf("/") + 1)));
            switch (Logica.AgregarEquipoEncuentroColectivo(nombre, categoria, encuentrosColectivos))
            {
                case 0:
                    this.refrescarEquiposEnEncuentro();
                    MessageBox.Show(Idiomas.equipoAgregado);
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado+": \n" + Idiomas.causasEquipo1 + " \n" + Idiomas.causasEquipo2 + " \n" + Idiomas.causasEquipo3);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.equipoNotieneJugadores);
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            paneModificarEvento.Enabled = true;
            paneDatosEvento.Enabled = false;
            btnEliminar.Enabled = false;
            btnCrearEventoColectivo.Enabled = false;
            btnAceptar.Enabled = false;
            btnCrearEventoColectivo.Enabled = false;
            txtDescripcionCole.Text = null;
            txtIDencuentroCole.Text = null;
            cmboxMinutoFinCole.Text = "00";
            cmboxHoraComienzo.Text = "00";
            cmboxMinutos.Text = "00";
            cmboxHoraFinCole.Text = "00";
        }

        private void btnCrearEventoColectivo_Click(object sender, EventArgs e)
        {
            encuentrosColectivos.idEncuentro = Convert.ToInt32(txtIDencuentroCole.Text);
            encuentrosColectivos.descripcion = txtDescripcionCole.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;

            fechaComienzo = dtimeFechaComienza.Text + " " + cmboxHoraComienzo.Text + ":" + cmboxMinutos.Text + ":00";
            encuentrosColectivos.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinaliza.Text + " " + cmboxHoraFinCole.Text + ":" + cmboxMinutoFinCole.Text + ":00";
            encuentrosColectivos.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = encuentrosColectivos.fechaComienzo.Year + "-" + encuentrosColectivos.fechaComienzo.Month + "-" + encuentrosColectivos.fechaComienzo.Day + " " + encuentrosColectivos.fechaComienzo.TimeOfDay;
            fechaF = encuentrosColectivos.fechaFinaliza.Year + "-" + encuentrosColectivos.fechaFinaliza.Month + "-" + encuentrosColectivos.fechaFinaliza.Day + " " + encuentrosColectivos.fechaFinaliza.TimeOfDay;
            encuentrosColectivos.nombreDeporte = cmboxDeportes.Text;
            switch (Logica.insertarEventoColectivo(encuentrosColectivos, fechaC, fechaF, encuentrosColectivos.nombreDeporte))
            {
                case 0:
                    MessageBox.Show(Idiomas.eventoActualizado);
                    paneModificarEvento.Enabled = true;
                    paneDatosEvento.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCrearEventoColectivo.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCrearEventoColectivo.Enabled = false;
                    txtDescripcionCole.Text = null;
                    txtIDencuentroCole.Text = null;
                    cmboxMinutoFinCole.Text = "00";
                    cmboxHoraComienzo.Text = "00";
                    cmboxMinutos.Text = "00";
                    cmboxHoraFinCole.Text = "00";
                    this.refrescarEventosColectivos();
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (Logica.EliminarEncuentro(encuentrosColectivos.idEncuentro, encuentrosColectivos.deporteEncuentro))
            {
                case 0:
                    MessageBox.Show("Encuentro eliminado");
                    this.refrescarEventosColectivos();
                    paneModificarEvento.Enabled = true;
                    paneDatosEvento.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCrearEventoColectivo.Enabled = false;
                    txtDescripcionCole.Text = null;
                    txtIDencuentroCole.Text = null;
                    cmboxMinutoFinCole.Text = "00";
                    cmboxHoraComienzo.Text = "00";
                    cmboxMinutos.Text = "00";
                    cmboxHoraFinCole.Text = "00";
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
        }  
        
    }
}
