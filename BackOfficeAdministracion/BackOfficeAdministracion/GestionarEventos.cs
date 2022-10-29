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
        public static EncuentrosIndividuales encuentrosIndividuales = new EncuentrosIndividuales();


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

        private void btnIncidenciasIndividuales_Click(object sender, EventArgs e)
        {
            Program.frmIncidenciasIndividuales.refrescarIncidencias();
            Program.frmIncidenciasIndividuales.refrescarParticipantesEncuentro();
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
            Program.frmAlineacion.refrescarEquiposCargados();
            Program.frmPrincipal.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            encuentrosColectivos.idEncuentro = Convert.ToInt32(cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3)));
            encuentrosColectivos.descripcion = txtDescripcionCole.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;

            fechaComienzo = dtimeFechaComienza.Text + " " + cmboxHoraComienzo.Text + ":" + cmboxMinutos.Text + ":00";
            encuentrosColectivos.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinaliza.Text + " " + cmboxHoraFinCole.Text + ":" + cmboxMinutoFinCole.Text + ":00";
            encuentrosColectivos.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = encuentrosColectivos.fechaComienzo.Year + "-" + encuentrosColectivos.fechaComienzo.Month + "-" + encuentrosColectivos.fechaComienzo.Day + " " + encuentrosColectivos.fechaComienzo.TimeOfDay; 
            fechaF = encuentrosColectivos.fechaFinaliza.Year + "-" + encuentrosColectivos.fechaFinaliza.Month + "-" + encuentrosColectivos.fechaFinaliza.Day +" " + encuentrosColectivos.fechaFinaliza.TimeOfDay;

            switch (Logica.ActualizarEventoColectivo(encuentrosColectivos, fechaC, fechaF))
            {
                case 0:
                    MessageBox.Show("Evento actualizado exitosamente");

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado. Verifique que los datos sean coherentes");
                    break;
            }
        }

        private void btnRefrescarEncuentrosIndividuales_Click(object sender, EventArgs e)
        {
            this.refrescarEventosIndividuales();
            this.refrescarParticipantesEnSistema();

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
        private void refrescarEventosIndividuales()
        {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreEncuentrosIndividuales(lista))
            {
                case 0:
                    cmboxEncuentroIndividua.Items.Clear();
                    cmboxEncuentroIndividua.Text = null;
                    cmboxEncuentroIndividua.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxEncuentroIndividua.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen eventos individuales cargados");
                    break;
            }
        }
        private void btnRefrescarEncuentroColectivo_Click(object sender, EventArgs e)
        {
            this.refrescarEventosColectivos();
            this.refrescarEquiposEnSistema();
        }
        private void refrescarParticipantesEnSistema()
        {
            List<string> lista = new List<string>();
            switch (Logica.ParticipantesEnSistema(lista))
            {
                case 0:
                    cmboxParticipantesIndi.Items.Clear();
                    cmboxParticipantesIndi.Text = null;
                    cmboxParticipantesIndi.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxParticipantesIndi.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen participantes en el sistema");
                    break;
            }
        }

        private void refrescarParticipantesEncuentro()
        {
            List<string> lista = new List<string>();
            switch (Logica.participantesEncuentrosIndividuales(encuentrosIndividuales.idEncuentro, lista))
            {
                case 0:
                    cmboxParticipantesIndiEncuentro.Items.Clear();
                    cmboxParticipantesIndiEncuentro.Text = null;
                    cmboxParticipantesIndiEncuentro.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxParticipantesIndiEncuentro.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen participantes en el encuentro");
                    break;
            }
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

            int id = 0;
            if (int.TryParse(cmboxIDEvento.Text.Substring(3, (cmboxIDEvento.Text.IndexOf(" ") - 3)), out id)){
                encuentrosColectivos.idEncuentro = id;

                List<string> equiposEncuentro = new List<string>();
                switch (Logica.DatosEncuentrosColectivos(encuentrosColectivos, equiposEncuentro))
                {
                    case 0:
                        txtDescripcionCole.Text = encuentrosColectivos.descripcion;
                        txtIDencuentroCole.Text = encuentrosColectivos.idEncuentro.ToString();
                        dtimeFechaComienza.Text = encuentrosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = encuentrosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = encuentrosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = encuentrosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = encuentrosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = encuentrosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Text = encuentrosColectivos.nombreDeporte;
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
                        DialogResult crearUsuario = MessageBox.Show("El Evento no existe, desea crearlo? ", "Creación evento", MessageBoxButtons.YesNo);
                        if (crearUsuario == DialogResult.Yes)
                        {
                            bool bandera = true; int idRandom = 0; Random r = new Random();
                            while (bandera == true)
                            {
                                idRandom = r.Next();
                                switch (Logica.BuscarIDEvento(idRandom))
                                {
                                    case 0:
                                        break;
                                    case 1:
                                    case 2:
                                        MessageBox.Show("Ocurrió un error, intente mas tarde");
                                        break;
                                    case 3:
                                        bandera = false;
                                        break;
                                }
                            }
                            txtIDencuentroCole.Text = idRandom.ToString();
                            cmboxEquiposenEncuentro.Items.Clear();

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
                        cmboxDeportes.Text = encuentrosColectivos.nombreDeporte;
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
            switch (Logica.AgregarEquipoEncuentroColectivo(nombre, categoria, encuentrosColectivos))
            {
                case 0:
                    this.refrescarEquiposEnEncuentro();
                    MessageBox.Show("Equipo agregado exitosamente");
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado. Las causas pueden ser: \n      El equipo se encuentra en este evento \n      Ya participa en otro evento a la misma fecha y hora \n      El equipo no practica el deporte del evento");
                    break;
                case 3:
                    MessageBox.Show("El equipo no tiene jugadores, no será agregado al evento");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcionCole.Text = null;
            txtIDencuentroCole.Text = null;
            cmboxEquiposenEncuentro.Text = null;
            cmboxHoraComienzo.Text = null;
            cmboxHoraFinCole.Text = null;
            cmboxMinutoFinCole.Text = null;
            cmboxMinutos.Text = null;
            cmboxDeportes.Text = null;
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

            switch (Logica.insertarEventoColectivo(encuentrosColectivos, fechaC, fechaF))
            {
                case 0:
                    MessageBox.Show("Evento creado exitosamente");
                    cmboxMinutoFinCole.Text = "0";
                    cmboxHoraFinCole.Text = "0";
                    cmboxMinutos.Text = "0";
                    cmboxHoraComienzo.Text = "0";
                    txtDescripcionCole.Text = null;
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
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
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
            }
        }

        private void btnBuscarIndividual_Click(object sender, EventArgs e)
        {
            List<string> nombresParticipante = new List<string>();
            int id;
            if (int.TryParse(cmboxEncuentroIndividua.Text.Substring(3, (cmboxEncuentroIndividua.Text.IndexOf(" ") - 3)), out id))
            {
                encuentrosIndividuales.idEncuentro = id;

                switch (Logica.DatosEncuentroIndividual(encuentrosIndividuales, nombresParticipante))
                {
                    case 0:
                        txtIDindi.Text = encuentrosIndividuales.idEncuentro.ToString();
                        txtDescripcionIndi.Text = encuentrosIndividuales.descripcion;

                        dtimeComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.ToString();
                        dtimeFechaFinalizaIndi.Text = encuentrosIndividuales.fechaFinaliza.ToString();
                        cmboxHoraComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.Hour.ToString();
                        cmboxMinutoComienzaIndi.Text = encuentrosIndividuales.fechaComienzo.Minute.ToString();
                        cmboxHoraFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Minute.ToString();
                        cmboxParticipantesIndiEncuentro.Items.Clear();
                        cmboxParticipantesIndiEncuentro.Text = nombresParticipante[0];
                        cmboxDeporteIndi.Text = encuentrosIndividuales.nombreDeporte;
                        foreach (string nombre in nombresParticipante)
                        {
                            cmboxParticipantesIndiEncuentro.Items.Add(nombre);
                        }

                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 3:
                        DialogResult crearEvento = MessageBox.Show("El Evento no existe, desea crearlo? ", "Creación evento", MessageBoxButtons.YesNo);
                        if (crearEvento == DialogResult.Yes)
                        {
                            bool bandera = true; int idRandom = 0; Random r = new Random();
                            while (bandera == true)
                            {
                                idRandom = r.Next();
                                switch (Logica.BuscarIDEvento(idRandom))
                                {
                                    case 0:
                                        break;
                                    case 1:
                                    case 2:
                                        MessageBox.Show("Ocurrió un error, intente mas tarde");
                                        break;
                                    case 3:
                                        bandera = false;
                                        break;
                                }
                            }
                            txtIDindi.Text = idRandom.ToString();
                            cmboxParticipantesIndiEncuentro.Items.Clear();

                        }
                        else
                        {

                        }
                        break;
                    case 4:
                        MessageBox.Show("El encuentro no está asociado a un deporte");
                        txtIDindi.Text = encuentrosIndividuales.idEncuentro.ToString();
                        txtDescripcionIndi.Text = encuentrosIndividuales.descripcion;

                        dtimeComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.ToString();
                        dtimeFechaFinalizaIndi.Text = encuentrosIndividuales.fechaFinaliza.ToString();
                        cmboxHoraComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.Hour.ToString();
                        cmboxMinutoComienzaIndi.Text = encuentrosIndividuales.fechaComienzo.Minute.ToString();
                        cmboxHoraFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Minute.ToString();
                        cmboxParticipantesIndiEncuentro.Items.Clear();
                        cmboxParticipantesIndiEncuentro.Text = nombresParticipante[0];
                        foreach (string nombre in nombresParticipante)
                        {
                            cmboxParticipantesIndiEncuentro.Items.Add(nombre);
                        }
                        break;
                    case 5:
                        MessageBox.Show("El encuentro no tiene participantes");
                        txtIDindi.Text = encuentrosIndividuales.idEncuentro.ToString();
                        txtDescripcionIndi.Text = encuentrosIndividuales.descripcion;
                        cmboxParticipantesIndiEncuentro.Items.Clear();

                        dtimeComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.ToString();
                        dtimeFechaFinalizaIndi.Text = encuentrosIndividuales.fechaFinaliza.ToString();
                        cmboxHoraComienzoIndi.Text = encuentrosIndividuales.fechaComienzo.Hour.ToString();
                        cmboxMinutoComienzaIndi.Text = encuentrosIndividuales.fechaComienzo.Minute.ToString();
                        cmboxHoraFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinIndi.Text = encuentrosIndividuales.fechaFinaliza.Minute.ToString();
                        cmboxDeporteIndi.Text = encuentrosIndividuales.nombreDeporte;

                        break;
                }
            }
            else {
                MessageBox.Show("ID no es valido. El formato debe ser:\nID:<IDencuentro> <NombreEncuentro>");
            }
        }

        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            string nombre = cmboxParticipantesIndi.Text.Substring(0, cmboxParticipantesIndi.Text.IndexOf(" "));
            string apellido = cmboxParticipantesIndi.Text.Substring((cmboxParticipantesIndi.Text.IndexOf(" ") + 1), (cmboxParticipantesIndi.Text.Length - (cmboxParticipantesIndi.Text.IndexOf(" ") + 1)));
            switch (Logica.AgregarParticipanteEncuentro(encuentrosIndividuales.idEncuentro, encuentrosIndividuales.deporteEncuentro, nombre, apellido))
            {
                case 0:
                    MessageBox.Show("Participante ingresado");
                    this.refrescarParticipantesEncuentro();
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado. Las posibles causas son:\n      El participante ya participa del encuentro ");
                    break;
            }
        }

        private void btnQuitarParticipanteEncuentro_Click(object sender, EventArgs e)
        {
            string nombre = cmboxParticipantesIndiEncuentro.Text.Substring(0, cmboxParticipantesIndiEncuentro.Text.IndexOf(" "));
            string apellido = cmboxParticipantesIndiEncuentro.Text.Substring((cmboxParticipantesIndiEncuentro.Text.IndexOf(" ") + 1), (cmboxParticipantesIndiEncuentro.Text.Length - (cmboxParticipantesIndiEncuentro.Text.IndexOf(" ") + 1)));
            switch (Logica.EliminarParticipanteEncuentro(encuentrosIndividuales.idEncuentro, encuentrosIndividuales.deporteEncuentro,  nombre, apellido))
            {
                case 0:
                    MessageBox.Show("Participante eliminado");
                    this.refrescarParticipantesEncuentro();
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
            }
        }

        private void btnAceptarIndi_Click(object sender, EventArgs e)
        {
            string fechaComienzo, fechaFin, fechaC, fechaF;
            int id;
            if (int.TryParse(txtIDindi.Text, out id))
            {
                encuentrosIndividuales.idEncuentro = id;
                encuentrosIndividuales.descripcion = txtDescripcionIndi.Text;

                fechaComienzo = dtimeComienzoIndi.Text + " " + cmboxHoraComienzoIndi.Text + ":" + cmboxMinutoComienzaIndi.Text + ":00";
                encuentrosIndividuales.fechaComienzo = Convert.ToDateTime(fechaComienzo);
                fechaFin = dtimeFechaFinalizaIndi.Text + " " + cmboxHoraFinIndi.Text + ":" + cmboxMinutoFinIndi.Text + ":00";
                encuentrosIndividuales.fechaFinaliza = Convert.ToDateTime(fechaFin);
                fechaC = encuentrosIndividuales.fechaComienzo.Year + "-" + encuentrosIndividuales.fechaComienzo.Month + "-" + encuentrosIndividuales.fechaComienzo.Day + " " + encuentrosIndividuales.fechaComienzo.TimeOfDay;
                fechaF = encuentrosIndividuales.fechaFinaliza.Year + "-" + encuentrosIndividuales.fechaFinaliza.Month + "-" + encuentrosIndividuales.fechaFinaliza.Day + " " + encuentrosIndividuales.fechaFinaliza.TimeOfDay;
                switch (Logica.ActualizarEncuentroIndividual(encuentrosIndividuales, fechaC, fechaF))
                {
                    case 0:
                        MessageBox.Show("Evento actualizado");
                        break;
                    case 1:
                        MessageBox.Show("Error de red");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                }
            }
            else {
                MessageBox.Show("ID no valido");
            }
            
        }

        private void btnEliminarIndi_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtIDindi.Text, out id))
            {
                encuentrosIndividuales.idEncuentro = id;

                switch (Logica.EliminarEncuentro(encuentrosIndividuales.idEncuentro, encuentrosIndividuales.deporteEncuentro))
                {
                    case 0:
                        MessageBox.Show("Encuentro eliminado");
                        this.refrescarEventosIndividuales();
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                }
            }
            else {
                MessageBox.Show("Error obteniendo ID");
            }
        }

        private void btnCrearEventoIndividual_Click(object sender, EventArgs e)
        {
            encuentrosIndividuales.idEncuentro = Convert.ToInt32(txtIDindi.Text);
            encuentrosIndividuales.descripcion = txtDescripcionIndi.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;

            fechaComienzo = dtimeComienzoIndi.Text + " " + cmboxHoraComienzoIndi.Text + ":" + cmboxMinutoComienzaIndi.Text + ":00";
            encuentrosIndividuales.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinalizaIndi.Text + " " + cmboxHoraFinIndi.Text + ":" + cmboxMinutoFinIndi.Text + ":00";
            encuentrosIndividuales.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = encuentrosIndividuales.fechaComienzo.Year + "-" + encuentrosIndividuales.fechaComienzo.Month + "-" + encuentrosIndividuales.fechaComienzo.Day + " " + encuentrosIndividuales.fechaComienzo.TimeOfDay;
            fechaF = encuentrosIndividuales.fechaFinaliza.Year + "-" + encuentrosIndividuales.fechaFinaliza.Month + "-" + encuentrosIndividuales.fechaFinaliza.Day + " " + encuentrosIndividuales.fechaFinaliza.TimeOfDay;
            switch (Logica.insertarEventoIndividual(encuentrosIndividuales, fechaC, fechaF))
            {
                case 0:
                    MessageBox.Show("Evento creado exitosamente");
                    cmboxMinutoFinCole.Text = "0";
                    cmboxHoraFinCole.Text = "0";
                    cmboxMinutos.Text = "0";
                    cmboxHoraComienzo.Text = "0";
                    txtDescripcionCole.Text = null;
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
            }
        }
    }
}
