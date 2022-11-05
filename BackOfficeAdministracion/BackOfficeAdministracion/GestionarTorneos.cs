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
    public partial class GestionarTorneos : Form
    {
        public GestionarTorneos()
        {
            InitializeComponent();
        }
        public static Torneos torneosColectivos = new Torneos();
        private void GestionarTorneos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

        private void btnCrearEventoColectivo_Click(object sender, EventArgs e)
        {
            torneosColectivos.idDeporteTorneo = Convert.ToInt32(txtIDencuentroCole.Text);
            torneosColectivos.nombreTorneo = txtDescripcionCole.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;
            fechaComienzo = dtimeFechaComienza.Text + " " + cmboxHoraComienzo.Text + ":" + cmboxMinutos.Text + ":00";
            torneosColectivos.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinaliza.Text + " " + cmboxHoraFinCole.Text + ":" + cmboxMinutoFinCole.Text + ":00";
            torneosColectivos.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = torneosColectivos.fechaComienzo.Year + "-" + torneosColectivos.fechaComienzo.Month + "-" + torneosColectivos.fechaComienzo.Day + " " + torneosColectivos.fechaComienzo.TimeOfDay;
            fechaF = torneosColectivos.fechaFinaliza.Year + "-" + torneosColectivos.fechaFinaliza.Month + "-" + torneosColectivos.fechaFinaliza.Day + " " + torneosColectivos.fechaFinaliza.TimeOfDay;
            torneosColectivos.nombreDeporte = cmboxDeportes.Text;
            switch (Logica.insertarTorneoColectivo(torneosColectivos, fechaC, fechaF))
            {
                case 0:
                    MessageBox.Show("Torneo creado exitosamente");
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
                    MessageBox.Show("Error inesperado. Verifique que los datos sean coherentes");
                    break;
            }
        }

        private void refrescarTorneosColectivos() {
            List<string> listaTorneosColectivos = new List<string>();
            switch (Logica.cargarNombreTorneosColectivos(listaTorneosColectivos)) {
                case 0:
                    cmboxIDTorneo.Items.Clear();
                    foreach (string nombreTorneo in listaTorneosColectivos) {
                        cmboxIDTorneo.Items.Add(nombreTorneo);
                    }
                    cmboxIDTorneo.Text = listaTorneosColectivos[0];
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break; 
                case 2:
                    MessageBox.Show("Error inesperado");
                        break;
                case 3:
                    MessageBox.Show("No existen torneos colectivos en el sistema");
                    break;
            }
        }
        private void btnRefrescarTorneoColectivo_Click(object sender, EventArgs e)
        {
            this.refrescarTorneosColectivos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int id = 0;
            if (int.TryParse(cmboxIDTorneo.Text.Substring(3, (cmboxIDTorneo.Text.IndexOf(" ") - 3)), out id))
            {
                torneosColectivos.idTorneo = id;

                List<string> equiposEncuentro = new List<string>();
                switch (Logica.datosTorneosColectivos(torneosColectivos, equiposEncuentro))
                {
                    case 0:
                        txtDescripcionCole.Text = torneosColectivos.nombreTorneo;
                        txtIDencuentroCole.Text = torneosColectivos.idTorneo.ToString();
                        dtimeFechaComienza.Text = torneosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = torneosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = torneosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = torneosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = torneosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = torneosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Items.Clear();
                        cmboxDeportes.Items.Add(torneosColectivos.nombreDeporte);
                        cmboxDeportes.Text = torneosColectivos.nombreDeporte;
                        cmboxEquiposenEncuentro.Items.Clear();
                        
                        foreach (string nombre in equiposEncuentro)
                        {
                            cmboxEquiposenEncuentro.Items.Add(nombre);
                        }
                        cmboxEquiposenEncuentro.Text = equiposEncuentro[0];

                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 3:
                        DialogResult crearTorneo = MessageBox.Show("El Torneo no existe, desea crearlo? ", "Creación torneo", MessageBoxButtons.YesNo);
                        if (crearTorneo == DialogResult.Yes)
                        {
                            
                            List<string> nombresDepo = new List<string>();
                            switch (Logica.nombresDeportes(nombresDepo))
                            {
                                case 0:
                                    cmboxDeportes.Items.Clear();
                                    foreach (string nombre in nombresDepo)
                                    {
                                        cmboxDeportes.Items.Add(nombre);
                                    }
                                    cmboxDeportes.Text = nombresDepo[0];
                                    break;

                                case 1:
                                case 2:
                                    MessageBox.Show("No se encuentran deportes en el sistema");
                                    break;

                            }
                            txtDescripcionCole.Text = cmboxIDTorneo.Text.Substring(cmboxIDTorneo.Text.IndexOf("-") + 1);
                            txtIDencuentroCole.Text = cmboxIDTorneo.Text.Substring(3, (cmboxIDTorneo.Text.IndexOf(" ") - 3));
                            cmboxIDTorneo.Text = null;
                            cmboxEquiposenEncuentro.Items.Clear();

                        }
                        else
                        {

                        }
                        break;
                    case 4:
                        MessageBox.Show("El torneo no está asociado a un deporte");
                        cmboxDeportes.Text = null;
                        txtDescripcionCole.Text = torneosColectivos.nombreTorneo;
                        txtIDencuentroCole.Text = torneosColectivos.idTorneo.ToString();
                        dtimeFechaComienza.Text = torneosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = torneosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = torneosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = torneosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = torneosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = torneosColectivos.fechaFinaliza.Minute.ToString();
                        break;
                    case 5:
                        MessageBox.Show("El Torneo no tiene equipos");
                        cmboxEquiposenEncuentro.Items.Clear();
                        cmboxEquiposenEncuentro.Text = null;
                        txtDescripcionCole.Text = torneosColectivos.nombreTorneo;
                        txtIDencuentroCole.Text = torneosColectivos.idTorneo.ToString();
                        dtimeFechaComienza.Text = torneosColectivos.fechaComienzo.ToString();
                        dtimeFechaFinaliza.Text = torneosColectivos.fechaFinaliza.ToString();
                        cmboxHoraComienzo.Text = torneosColectivos.fechaComienzo.Hour.ToString();
                        cmboxMinutos.Text = torneosColectivos.fechaComienzo.Minute.ToString();
                        cmboxHoraFinCole.Text = torneosColectivos.fechaFinaliza.Hour.ToString();
                        cmboxMinutoFinCole.Text = torneosColectivos.fechaFinaliza.Minute.ToString();
                        cmboxDeportes.Items.Add(torneosColectivos.nombreDeporte);
                        cmboxDeportes.Text = torneosColectivos.nombreDeporte;
                        cmboxEquiposenEncuentro.Items.Clear();
                        break;
                    case 6:
                        MessageBox.Show("El id pertenece a un torneo individual");
                        break;
                }
            }
            else
            {
                MessageBox.Show("ID no es valido. El formato debe ser:\nID:<IDtorneo> <NombreTorneo>");
            }
        }

        private void cmboxDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            torneosColectivos.idTorneo = Convert.ToInt32(cmboxIDTorneo.Text.Substring(3, (cmboxIDTorneo.Text.IndexOf(" ") - 3)));
            torneosColectivos.nombreTorneo = txtDescripcionCole.Text;
            string fechaComienzo, fechaFin, fechaC, fechaF;
            torneosColectivos.nombreDeporte = cmboxDeportes.Text;
            fechaComienzo = dtimeFechaComienza.Text + " " + cmboxHoraComienzo.Text + ":" + cmboxMinutos.Text + ":00";
            torneosColectivos.fechaComienzo = Convert.ToDateTime(fechaComienzo);
            fechaFin = dtimeFechaFinaliza.Text + " " + cmboxHoraFinCole.Text + ":" + cmboxMinutoFinCole.Text + ":00";
            torneosColectivos.fechaFinaliza = Convert.ToDateTime(fechaFin);
            fechaC = torneosColectivos.fechaComienzo.Year + "-" + torneosColectivos.fechaComienzo.Month + "-" + torneosColectivos.fechaComienzo.Day + " " + torneosColectivos.fechaComienzo.TimeOfDay;
            fechaF = torneosColectivos.fechaFinaliza.Year + "-" + torneosColectivos.fechaFinaliza.Month + "-" + torneosColectivos.fechaFinaliza.Day + " " + torneosColectivos.fechaFinaliza.TimeOfDay;

            switch (Logica.ActualizarTorneoColectivo(torneosColectivos, fechaC, fechaF))
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

        private void cmboxHoraComienzo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idTorneo;
            if (int.TryParse(txtIDencuentroCole.Text, out idTorneo))
            {
                torneosColectivos.idTorneo = idTorneo;
                switch (Logica.BorrarTorneo(torneosColectivos.idTorneo, torneosColectivos.idDeporteTorneo)) {
                    case 0:
                        MessageBox.Show("Torneo eliminado");
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado, verifique los datos");
                        break;
                }
            }
            else {
                MessageBox.Show("Error obteniendo ID");
            }
        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            Program.frmEncuentrosTorneos.StartPosition = FormStartPosition.CenterScreen;
            Program.frmEncuentrosTorneos.TopMost = true;
            Program.frmEncuentrosTorneos.Visible = true;
            Program.frmPrincipal.Enabled = false;
        }
    }
}
