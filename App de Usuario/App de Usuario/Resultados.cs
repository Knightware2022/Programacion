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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }
        public static EncuentrosColectivos encuentros = new EncuentrosColectivos();
        private void ocultarMostrarFiltros()
        {
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            txtFechaFin.Text = null;
            cmboxEquiposParticipan.Items.Clear();
            cmboxEquiposParticipan.Text = null;
            cmboxNombreEvento.Items.Clear();
            cmboxNombreEvento.Text = null;
            if (rbDeporte.Checked)
            {
                cmboxEquipos.Enabled = false;
                cmboxDeporte.Enabled = true;

            }
            else
            {
                if (rbEquipo.Checked)
                {
                    cmboxEquipos.Enabled = true;
                    cmboxDeporte.Enabled = false;
                }
                else
                {
                    cmboxEquipos.Enabled = true;
                    cmboxDeporte.Enabled = true;

                }
            }

        }
        private void refrescarDeportes()
        {
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
                    MessageBox.Show("Error inesperado, tal vez no hay deportes cargados");
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
                            MessageBox.Show("No se han cargado equipos al evento");
                        }
                        cmboxEquiposParticipan.Text = Equipos[0];

                        break;
                    case 5:
                        txtDeporteEvento.Text = encuentros.nombreDeporte;
                        txtFechaComienzo.Text = encuentros.fechaComienzo.ToString();
                        txtFechaFin.Text = encuentros.fechaFinaliza.ToString();
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
                    MessageBox.Show("Error inesperado, tal vez no hay equipos cargados");
                    break;
            }
        }
        private void verResultado() {
            int id;
            if (int.TryParse(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")), out id)) {
                List<string> nombreEquipo = new List<string>();
                List<string> puntos_Sets = new List<string>();
                List<string> logo = new List<string>();
                lstResultado.Items.Clear();
                if (rbPuntos.Checked)
                {
                    switch (ApiResultados.ConsultarResultadoPuntos(nombreEquipo, puntos_Sets, logo, id)) {
                        case 0:
                            for (int i = 0; i < nombreEquipo.Count; i++)
                            {
                                ListViewItem item = new ListViewItem(nombreEquipo[i]);
                                item.SubItems.Add(puntos_Sets[i]);
                                lstResultado.Items.Add(item);
                            }                           
                            break;
                        default:
                            MessageBox.Show("Error inesperado");
                            break;
                    }
                }
                else {
                    if (rbSets.Checked)
                    {
                        switch (ApiResultados.ConsultarResultadosSets(nombreEquipo, puntos_Sets, logo, id))
                        {
                            case 0:
                                for (int i = 0; i < nombreEquipo.Count; i++)
                                {
                                    ListViewItem item = new ListViewItem(nombreEquipo[i]);
                                    item.SubItems.Add("");
                                    item.SubItems.Add(puntos_Sets[i]);
                                    lstResultado.Items.Add(item);
                                }
                                break;
                            default:
                                MessageBox.Show("Error inesperado");
                                break;
                        }
                    }
                    else if(rbRanking.Checked){
                        switch (ApiResultados.ConsultarResultadosRankings(nombreEquipo, puntos_Sets, logo, id))
                        {
                            case 0:
                                for (int i = 0; i < nombreEquipo.Count; i++)
                                {
                                    ListViewItem item = new ListViewItem(nombreEquipo[i]);
                                    item.SubItems.Add(puntos_Sets[i]);
                                    lstResultado.Items.Add(item);
                                }
                                break;
                            default:
                                MessageBox.Show("Error inesperado");
                                break;
                        }
                    }
                }
            }
            else{
                MessageBox.Show("Error inesperado");
            }
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;
            this.refrescarEquipos();
            this.refrescarDeportes();
            rbDeporte.Checked = true;
            this.ocultarMostrarFiltros();
           // rbPuntos.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarDeportes();
            this.refrescarEquipos();
        }

        private void rbDeporte_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();

        }

        private void rbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();

        }

        private void rbTodoslosFiltros_CheckedChanged(object sender, EventArgs e)
        {
            this.ocultarMostrarFiltros();
        }

        private void cmboxNombreEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DatosDeportes();
            this.verResultado();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<string> listaDEventos = new List<string>();
            this.ocultarMostrarFiltros();
            if (rbDeporte.Checked)
            {
                encuentros.nombreDeporte = cmboxDeporte.Text;
                switch (ApiResultados.EventosJugadosxJugar(listaDEventos, encuentros.nombreDeporte))
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
                        MessageBox.Show("No existen eventos jugados o por jugar con estas características");
                        break;
                }
            }
            else
            {
                if (rbEquipo.Checked)
                {
                    string nombre = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                    string categoria = cmboxEquipos.Text.Substring((cmboxEquipos.Text.IndexOf("/") + 1), (cmboxEquipos.Text.Length - (cmboxEquipos.Text.IndexOf("/") + 1)));
                    switch (ApiResultados.EventosJugadosxJugarconEquipo(listaDEventos, nombre, categoria))
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
                            MessageBox.Show("No existen eventos jugados o por jugar con estas características");
                            break;
                    }
                }
                else
                {
                    string deporte = cmboxDeporte.Text;
                    string nombre = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                    string categoria = cmboxEquipos.Text.Substring((cmboxEquipos.Text.IndexOf("/") + 1), (cmboxEquipos.Text.Length - (cmboxEquipos.Text.IndexOf("/") + 1)));
                    switch (ApiResultados.EventosJugadosxJugarConTodosLosFiltros(listaDEventos, nombre, categoria, deporte))
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
                            MessageBox.Show("No existen eventos jugados o por jugar con estas características");
                            break;
                    }

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.frmAlineacion.StartPosition = FormStartPosition.CenterScreen;
            Program.frmPrincipal.Enabled = false;
            Program.frmAlineacion.Visible = true;
            Program.frmAlineacion.TopMost = true;
            Program.frmAlineacion.refrescarEquiposCargados();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Program.frmIncidencias.StartPosition = FormStartPosition.CenterScreen;
            Program.frmPrincipal.Enabled = false;
            Program.frmIncidencias.Visible = true;
            Program.frmIncidencias.TopMost = true;
            Program.frmIncidencias.refrescarEquiposCargados();
            Program.frmIncidencias.mostrarIncidencias();
        }

        private void rbPuntos_CheckedChanged(object sender, EventArgs e)
        {
            this.verResultado();
        }

        private void rbSets_CheckedChanged(object sender, EventArgs e)
        {
            this.verResultado();

        }

        private void rbRanking_CheckedChanged(object sender, EventArgs e)
        {
            this.verResultado();
        }
    }
    
}
