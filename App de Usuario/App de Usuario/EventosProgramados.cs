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
    public partial class EventosProgramados : Form
    {
        public EventosProgramados()
        {
            InitializeComponent();
        }
        private EncuentrosColectivos encuentros = new EncuentrosColectivos();
        private void EventosProgramados_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;
            rbDeporte.Checked = true;
            refrescarDeportes();
            refrescarEquipos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void refrescarEquipos()
        {
            List<string> deportes = new List<string>();
            switch (ApiResultados.obtenerEquiposEnSistema(deportes))
            {
                case 0:
                    cmboxEquipos.Items.Clear();
                    foreach (string nombre in deportes)
                    {
                        cmboxEquipos.Items.Add(nombre);
                    }
                    cmboxEquipos.Text = deportes[0];
                    break;
                default:
                    MessageBox.Show(Idiomas.ErrorEquiposNOHAYSISTEMA);
                    break;
            }
        }

        private void ocultarMostrarFiltros() {
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            txtFechaFin.Text = null;
            cmboxJugadoresEquipos.Items.Clear();
            cmboxEquiposParticipan.Items.Clear();
            cmboxEquiposParticipan.Text = null;
            cmboxJugadoresEquipos.Text = null;
            cmboxNombreEvento.Items.Clear();
            cmboxNombreEvento.Text = null;
            if (rbDeporte.Checked)
            {
                cmboxEquipos.Enabled = false;
                cmboxDeporte.Enabled = true;
                
            }
            else {
                if (rbEquipo.Checked)
                {
                    cmboxEquipos.Enabled = true;
                    cmboxDeporte.Enabled = false;
                }
                else {
                        cmboxEquipos.Enabled = true;
                        cmboxDeporte.Enabled = true;
                    
                }
            }

        }
        private void refrescarDeportes() {
            List<string> deportes = new List<string>();
            switch (ApiResultados.obtenerDeportesenSistema(deportes))
            {
                case 0:
                    cmboxDeporte.Items.Clear();
                    foreach (string nombre in deportes)
                    {
                        cmboxDeporte.Items.Add(nombre);
                    }
                    cmboxDeporte.Text = deportes[0];
                    break;
                default:
                    MessageBox.Show(Idiomas.ErrorDeportesNOHAYSISTEMA);
                    break;
            }
        }
        private void DatosDeportes()
        {
            List<string> Equipos = new List<string>();
            int id;

            if (int.TryParse(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")), out id))
            {
                encuentros.idEncuentro = id;
                switch (ApiResultados.datosEventosProgramados(encuentros, Equipos))
                {
                    case 0:
                        txtDeporteEvento.Text = encuentros.nombreDeporte;
                        txtFechaComienzo.Text = encuentros.fechaComienzo.ToString();
                        txtFechaFin.Text = encuentros.fechaFinaliza.ToString();

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
                            MessageBox.Show(Idiomas.EventosSinEquipos);
                        }
                        cmboxEquiposParticipan.Text = Equipos[0];

                        break;
                    case 5:
                        txtDeporteEvento.Text = encuentros.nombreDeporte;
                        txtFechaComienzo.Text = encuentros.fechaComienzo.ToString();
                        txtFechaFin.Text = encuentros.fechaFinaliza.ToString();
                        MessageBox.Show(Idiomas.EventosSinEquipos);

                        cmboxEquiposParticipan.Items.Clear();
                        cmboxEquiposParticipan.Text = null;
                        break;
                    default:
                        MessageBox.Show(Idiomas.errorConexion);
                        break;
                }
            }
            else {
                MessageBox.Show(Idiomas.errorInesperado);
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
                            MessageBox.Show(Idiomas.EquipoSinJugadores);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.errorConexion);
                }
            }
            catch {
                MessageBox.Show(Idiomas.EventosSinEquipos);
            }
        }


        private void rbDeporte_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();
        }

        private void rbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();

        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();

        }

        private void rbTodoslosFiltros_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<string> listaDEventos = new List<string>();
            this.ocultarMostrarFiltros();
            if (rbDeporte.Checked)
            {
                encuentros.nombreDeporte = cmboxDeporte.Text;
                switch (ApiResultados.EventosProgramados(listaDEventos, encuentros.nombreDeporte))
                {
                    case 0:
                        cmboxNombreEvento.Items.Clear();
                        foreach (string nombre in listaDEventos)
                        {
                            cmboxNombreEvento.Items.Add(nombre);
                        }
                        cmboxNombreEvento.Text = listaDEventos[0];
                        break;
                    default:
                        MessageBox.Show(Idiomas.NOseenontroconfiltros);
                        break;
                }
            }
            else {
                if (rbEquipo.Checked)
                {
                    string nombre = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                    string categoria = cmboxEquipos.Text.Substring((cmboxEquipos.Text.IndexOf("/") + 1), (cmboxEquipos.Text.Length - (cmboxEquipos.Text.IndexOf("/") + 1)));
                    switch (ApiResultados.EventosProgramadosconEquipo(listaDEventos, nombre, categoria))
                    {
                        case 0:
                            cmboxNombreEvento.Items.Clear();
                            foreach (string nombreEvento in listaDEventos)
                            {
                                cmboxNombreEvento.Items.Add(nombreEvento);
                            }
                            cmboxNombreEvento.Text = listaDEventos[0];
                            break;
                        default:
                            MessageBox.Show(Idiomas.NOseenontroconfiltros);
                            break;
                    }
                }
                else {
                    string deporte = cmboxDeporte.Text;
                    string nombre = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                    string categoria = cmboxEquipos.Text.Substring((cmboxEquipos.Text.IndexOf("/") + 1), (cmboxEquipos.Text.Length - (cmboxEquipos.Text.IndexOf("/") + 1)));
                    switch (ApiResultados.EventosProgramadosconTodosLosFiltros(listaDEventos, nombre, categoria, deporte))
                    {
                        case 0:
                            cmboxNombreEvento.Items.Clear();
                            foreach (string nombreEvento in listaDEventos)
                            {
                                cmboxNombreEvento.Items.Add(nombreEvento);
                            }
                            cmboxNombreEvento.Text = listaDEventos[0];
                            break;
                        default:
                            MessageBox.Show(Idiomas.NOseenontroconfiltros);
                            break;
                    }

                }

            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();
            this.refrescarDeportes();
            this.refrescarEquipos();
        }

        private void cmboxNombreEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DatosDeportes();
            this.refrescarJugadores();
        }

        private void cmboxEquiposParticipan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            switch (ApiResultados.SuscribirseAEvento(encuentros.idEncuentro, encuentros.deporteEncuentro, Login.nombreUsuario)) {
                case 0:
                    MessageBox.Show(Idiomas.promesaNotificacion);
                    break;
              /*  case 2:
                    MessageBox.Show("Error inesperado. Ya se ha suscripto o usted no es VIP");
                    break;*/
            }
        }
    }
}
