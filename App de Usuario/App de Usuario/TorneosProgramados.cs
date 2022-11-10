using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public partial class TorneosProgramados : Form
    {
        public TorneosProgramados()
        {
            InitializeComponent();
        }
        Torneos torneo = new Torneos();
        EncuentrosColectivos encuentros = new EncuentrosColectivos();
        private void refrescarTorneos()
        {
            List<string> torneos = new List<string>();
            switch (ApiResultados.TorneosProgramados(torneos))
            {
                case 0:
                    cmboxTorneos.Items.Clear();
                    foreach (string nombre in torneos)
                    {
                        cmboxTorneos.Items.Add(nombre);
                    }
                    cmboxTorneos.Text = torneos[0];
                    break;
                case 3:
                    MessageBox.Show("No existen deportes programados");
                    break;
                default:
                    MessageBox.Show("Error de conexion");
                    break;
            }
        }
        private void refrescarEventos()
        {
            List<string> eventos = new List<string>();
            int id;
            if (int.TryParse(cmboxTorneos.Text.Substring(0, cmboxTorneos.Text.IndexOf(" ")), out id))
            {
                switch (ApiResultados.EventosDeTorneo(eventos, id))
                {
                    case 0:
                        cmboxNombreEvento.Items.Clear();
                        foreach (string nombre in eventos)
                        {
                            cmboxNombreEvento.Items.Add(nombre);
                        }
                        cmboxNombreEvento.Text = eventos[0];
                        break;
                    case 3:
                        txtDeporteEvento.Text = null;
                        txtFechaComienzo.Text = null;
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxNombreEvento.Items.Clear();
                        MessageBox.Show("No existen eventos programados para este torneo");
                        break;
                    default:
                        txtDeporteEvento.Text = null;
                        txtFechaComienzo.Text = null;
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxNombreEvento.Items.Clear();
                        MessageBox.Show("Error de conexion");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error obteniendo id");
            }
        }
        private void DatosTorneo()
        {
            List<string> Equipos = new List<string>();
            int id;
            try
            {
                if (int.TryParse(cmboxTorneos.Text.Substring(0, cmboxTorneos.Text.IndexOf(" ")), out id))
                {
                    torneo.idTorneo = id;
                    switch (ApiResultados.datosTorneosProgramados(torneo, Equipos))
                    {
                        case 0:
                            txtDeporteEvento.Text = torneo.nombreDeporte;
                            txtFechaComienzo.Text = torneo.fechaComienzo.ToString();
                            txtFechaFin.Text = torneo.fechaFinaliza.ToString();

                            cmboxEquiposParticipan.Items.Clear();
                            try
                            {
                                foreach (string nombre in Equipos)
                                {
                                    cmboxEquiposParticipan.Items.Add(nombre);
                                }
                                cmboxEquiposParticipan.Text = Equipos[0];
                            }
                            catch
                            {
                                MessageBox.Show("No se han cargado equipos al evento");
                            }
                            cmboxEquiposParticipan.Text = Equipos[0];

                            break;
                        case 5:
                            txtDeporteEvento.Text = torneo.nombreDeporte;
                            txtFechaComienzo.Text = torneo.fechaComienzo.ToString();
                            txtFechaFin.Text = torneo.fechaFinaliza.ToString();
                            MessageBox.Show("No se han cargado equipos al evento");

                            cmboxEquiposParticipan.Items.Clear();
                            cmboxEquiposParticipan.Text = null;
                            break;
                        default:
                            MessageBox.Show("Error de conexion");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error inesperado");
                }
            }
            catch {
                MessageBox.Show("Error obteniendo id");
            }
        }
        private void refrescarJugadores()
        {
            int id;
            try
            {
                string nombre = cmboxEquiposParticipan.Text.Substring(0, cmboxEquiposParticipan.Text.IndexOf("/"));
                string categoria = cmboxEquiposParticipan.Text.Substring((cmboxEquiposParticipan.Text.IndexOf("/") + 1), (cmboxEquiposParticipan.Text.Length - (cmboxEquiposParticipan.Text.IndexOf("/") + 1)));
                if (int.TryParse(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")), out id))
                {
                    List<string> jugadores = new List<string>();
                    switch (ApiResultados.JugadoresDeEventos(nombre, categoria, id, jugadores))
                    {
                        case 0:
                            cmboxJugadoresEquipos.Items.Clear();
                            foreach (string nombreJugador in jugadores)
                            {
                                cmboxJugadoresEquipos.Items.Add(nombreJugador);
                            }
                            cmboxJugadoresEquipos.Text = jugadores[0];
                            break;
                        default:
                            MessageBox.Show("Error inesperado, tal vez no hay jugadores cargados");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error inesperado");
                }
            }
            catch
            {
                MessageBox.Show("El evento no tiene equipos");
            }
        }


        private void TorneosProgramados_Load(object sender, EventArgs e)
        {
            refrescarTorneos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            cmboxJugadoresEquipos.Items.Clear();
            cmboxJugadoresEquipos.Items.Clear();
            cmboxNombreEvento.Items.Clear();
            this.Visible = false;
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarTorneos();
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            cmboxJugadoresEquipos.Items.Clear();
            cmboxJugadoresEquipos.Items.Clear();
            cmboxNombreEvento.Items.Clear();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.refrescarEventos();
            this.DatosTorneo();
        }

        private void cmboxNombreEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxEquiposParticipan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadores();
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            List<string> idEventos = new List<string>();
            for (int i = 0; i < cmboxNombreEvento.Items.Count; i++) {
                idEventos.Add(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")));
                cmboxNombreEvento.SelectedIndex = i;
                idEventos.Add(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")));

            }
            switch (ApiResultados.SuscribirseATorneos(idEventos, txtDeporteEvento.Text, Login.nombreUsuario)) {
                case 0:

                    MessageBox.Show("Se ha suscripto al torneo");
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Se ha suscripto a los eventos del torneo que restaban");
                    break;
            }
        }
    }
}
