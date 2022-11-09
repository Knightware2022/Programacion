using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }
        EncuentrosColectivos c = new EncuentrosColectivos();
        public void mostrarIncidencias()
        {
            lstviewIncidencias.Items.Clear();
            List<string> Nombrej = new List<string>();
            List<string> Apellidoj = new List<string>();
            List<string> Ocurrencia = new List<string>();
            List<string> Equipoj = new List<string>();
            List<string> minuto = new List<string>();
            List<string> puntos = new List<string>();

            string nombreEquipo = cmboxEquipo.Text.Substring(0, cmboxEquipo.Text.IndexOf("/"));
            string categoriaEquipo = cmboxEquipo.Text.Substring((cmboxEquipo.Text.IndexOf("/") + 1), (cmboxEquipo.Text.Length - (cmboxEquipo.Text.IndexOf("/") + 1)));
            switch (ApiResultados.ConsultarIncidencias(Nombrej, Apellidoj, Ocurrencia, Equipoj, Resultados.encuentros.idEncuentro, nombreEquipo, categoriaEquipo, c, puntos, minuto))
            {
                case 0:
                    for (int i = 0; i < Nombrej.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(Nombrej[i]);
                        item.SubItems.Add(Apellidoj[i]);
                        item.SubItems.Add(minuto[i]);
                        item.SubItems.Add(Ocurrencia[i]);
                        item.SubItems.Add(puntos[i]);
                        lstviewIncidencias.Items.Add(item);
                    }
                    try
                    {
                        var request = WebRequest.Create(c.nombreDeporte);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pcboxLogo.Image = Bitmap.FromStream(stream);
                        }
                    }
                    catch
                    {

                        this.pcboxLogo.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
                    }
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
                case 3:
                    lstviewIncidencias.Items.Clear();
                    MessageBox.Show("EL equipo no tiene alineacion");
                    break;
            }
        }
        public void refrescarEquiposCargados()
        {
            List<string> nombresEquipos = new List<string>();
            switch (ApiResultados.ConsultarEquiposAlineacion(Resultados.encuentros.idEncuentro, nombresEquipos))
            {
                case 0:
                    cmboxEquipo.Items.Clear();
                    cmboxEquipo.Text = null;
                    foreach (string nombre in nombresEquipos)
                    {
                        cmboxEquipo.Items.Add(nombre);
                    }
                    cmboxEquipo.Text = nombresEquipos[0];
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado.\nRefresque la pagina e intente nuevamente");
                    break;
                case 3:
                    MessageBox.Show("El encuentro no tiene equipos cargados");
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Enabled = true;
            this.Visible = false;
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            this.mostrarIncidencias();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarEquiposCargados();
        }

        private void cmboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mostrarIncidencias();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

        }
    }
}
