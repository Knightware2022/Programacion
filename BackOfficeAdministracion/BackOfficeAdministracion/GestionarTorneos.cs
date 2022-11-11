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
        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {
            tbpgTorneosColectivos.BackColor = fondo;
            lblIDmodificar.ForeColor = letra;
            btnBuscar.BackColor = boton;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = boton;
            btnBuscar.ForeColor = letra;
            btnRefrescarTorneoColectivo.BackColor = boton;
            btnRefrescarTorneoColectivo.FlatStyle = FlatStyle.Flat;
            btnRefrescarTorneoColectivo.FlatAppearance.BorderColor = boton;
            btnRefrescarTorneoColectivo.ForeColor = letra;

            lblIDEncuentroCole.ForeColor = letra;
            lblDeporte.ForeColor = letra;
            lblEquiposenEncuentro.ForeColor = letra;
            lblFechaComienzo.ForeColor = letra;
            lblHoraComienzo.ForeColor = letra;
            lblHoraComienza.ForeColor = letra;
            lblMinutosComienza.ForeColor = letra;
            lblFechaFinalizaCole.ForeColor = letra;
            lblFinalizaColectivo.ForeColor = letra;
            lblHoraFinalizaColec.ForeColor = letra;
            lblMinutoFinCole.ForeColor = letra;
            lblDescripcionColect.ForeColor = letra;

            btnEncuentros.BackColor = boton;
            btnEncuentros.FlatStyle = FlatStyle.Flat;
            btnEncuentros.FlatAppearance.BorderColor = boton;
            btnEncuentros.ForeColor = letra;
            btnAceptarCambios.BackColor = boton;
            btnAceptarCambios.FlatStyle = FlatStyle.Flat;
            btnAceptarCambios.FlatAppearance.BorderColor = boton;
            btnAceptarCambios.ForeColor = letra;
            btnLimpiarCampos.BackColor = boton;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.FlatAppearance.BorderColor = boton;
            btnLimpiarCampos.ForeColor = letra;
            btnEliminar.BackColor = boton;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderColor = boton;
            btnEliminar.ForeColor = letra;
            btnDelete.BackColor = boton;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderColor = boton;
            btnDelete.ForeColor = letra;
            btnClose.BackColor = boton;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderColor = boton;
            btnClose.ForeColor = letra;
            btnCrearTorneo.BackColor = boton;
            btnCrearTorneo.FlatStyle = FlatStyle.Flat;
            btnCrearTorneo.FlatAppearance.BorderColor = boton;
            btnCrearTorneo.ForeColor = letra;
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
                    MessageBox.Show(Idiomas.torneoCreado);
                    btnAceptarCambios.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCrearTorneo.Enabled = false;
                    btnEncuentros.Enabled = false;
                    paneDatos.Enabled = false;
                    paneID.Enabled = true;
                    txtDescripcionCole.Text = null;
                    txtIDencuentroCole.Text = null;
                    cmboxHoraComienzo.Text = "00";
                    cmboxHoraFinCole.Text = "00";
                    cmboxMinutoFinCole.Text = "00";
                    cmboxMinutos.Text = "00";
                    this.refrescarTorneosColectivos();
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break; 
                case 2:
                    MessageBox.Show(Idiomas.errordeConexion);
                        break;
                case 3:
                    MessageBox.Show(Idiomas.noExistenTorneos);
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
                        paneID.Enabled = false;
                        paneDatos.Enabled = true;
                        btnEncuentros.Enabled = true;
                        btnAceptarCambios.Enabled = true;
                        btnDelete.Enabled = true;
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
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 3:
                        DialogResult crearTorneo = MessageBox.Show(Idiomas.crearTorneo, Idiomas.tituloCrearTorneo, MessageBoxButtons.YesNo);
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
                            btnAceptarCambios.Enabled = false;
                            btnDelete.Enabled = false;
                            btnCrearTorneo.Enabled = true;
                            btnEncuentros.Enabled = false;
                            paneDatos.Enabled = true;
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
                        paneID.Enabled = false;
                        paneDatos.Enabled = true;
                        btnEncuentros.Enabled = false;
                        btnAceptarCambios.Enabled = true;
                        btnDelete.Enabled = true;
                        break;
                    case 5:
                        torneosColectivos.idTorneo = id;
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
                        paneID.Enabled = false;
                        paneDatos.Enabled = true;
                        btnEncuentros.Enabled = true;
                        btnAceptarCambios.Enabled = true;
                        btnDelete.Enabled = true;
                        break;
                    case 6:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Format should be :\nID:<IDtorneo> <NombreTorneo>");
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
                    btnAceptarCambios.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCrearTorneo.Enabled = false;
                    btnEncuentros.Enabled = false;
                    paneDatos.Enabled = false;
                    paneID.Enabled = true;
                    txtDescripcionCole.Text = null;
                    txtIDencuentroCole.Text = null;
                    cmboxHoraComienzo.Text = "00";
                    cmboxHoraFinCole.Text = "00";
                    cmboxMinutoFinCole.Text = "00";
                    cmboxMinutos.Text = "00";
                    refrescarTorneosColectivos();
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
                        btnAceptarCambios.Enabled = false;
                        btnDelete.Enabled = false;
                        btnCrearTorneo.Enabled = false;
                        btnEncuentros.Enabled = false;
                        paneDatos.Enabled = false;
                        paneID.Enabled = true;
                        txtDescripcionCole.Text = null;
                        txtIDencuentroCole.Text = null;
                        cmboxHoraComienzo.Text = "00";
                        cmboxHoraFinCole.Text = "00";
                        cmboxMinutoFinCole.Text = "00";
                        cmboxMinutos.Text = "00";
                        refrescarTorneosColectivos();
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado, el torneo tiene encuentros");
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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            btnAceptarCambios.Enabled = false;
            btnDelete.Enabled = false;
            btnCrearTorneo.Enabled = false;
            btnEncuentros.Enabled = false;
            paneDatos.Enabled = false;
            paneID.Enabled = true;
            txtDescripcionCole.Text = null;
            txtIDencuentroCole.Text = null;
            cmboxHoraComienzo.Text = "00";
            cmboxHoraFinCole.Text = "00";
            cmboxMinutoFinCole.Text = "00";
            cmboxMinutos.Text = "00";
            refrescarTorneosColectivos();
        }
    }
}
