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
    public partial class Deportes_Favoritos : Form
    {
        public Deportes_Favoritos()
        {
            InitializeComponent();
        }

        private void Deportes_Favoritos_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;

        }

        private void paneDeportesFavoritos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVentanas.Visible = true;
        }
        
        private void RefrescarDeportesEnSistema()
        {

            List<string> listaDepo = new List<string>();
            switch (ApiResultados.obtenerDeportesenSistema(listaDepo))
            {
                case 0:
                    cmboxDeportes.Items.Clear();
                    foreach (string nombre in listaDepo)
                    {
                        cmboxDeportes.Items.Add(nombre);
                    }
                    try
                    {
                        cmboxDeportes.Text = listaDepo[0];

                    }
                    catch
                    {
                        MessageBox.Show("No existen deportes en el sistema");
                    }
                    break;
                default:
                    MessageBox.Show("Error de conexion");
                    break;
            }
        }
        private void refrescarFavoritos() {

            List<string> listaDeportesFavo = new List<string>();
            switch (ApiResultados.obtenerDeportesFavoritos(listaDeportesFavo)) {
                case 0:
                    cmboxDeportesFavoritos.Items.Clear();
                    foreach (string nombre in listaDeportesFavo) {
                        cmboxDeportesFavoritos.Items.Add(nombre);
                    }
                    try
                    {
                        cmboxDeportesFavoritos.Text = listaDeportesFavo[0];

                    }
                    catch {
                        MessageBox.Show("Usted no posee deportes favoritos");
                    }
                        break;
                default:
                    MessageBox.Show("Error de conexion");
                    break;
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            this.refrescarFavoritos();
            this.RefrescarDeportesEnSistema();
        }

        private void btnEliminarFavoritos_Click(object sender, EventArgs e)
        {
            switch (ApiResultados.EliminarDeportesFavoritos(cmboxDeportesFavoritos.Text))
            {
                case 0:
                    MessageBox.Show("Ya no sigues este deporte");
                    this.refrescarFavoritos();
                    break;
                default:
                    MessageBox.Show("Error inesperado. Compruebe su conexion o que seleccionó un deporte");
                    break;
            }
        }

        private void btnAgregarDeporteFavorito_Click(object sender, EventArgs e)
        {
            
            switch (ApiResultados.AgregarDeportesFavoritos(cmboxDeportes.Text))
            {
                case 0:
                    MessageBox.Show("Ya sigues este deporte");
                    this.refrescarFavoritos();
                    break;
                default:
                    MessageBox.Show(ApiResultados.usuario.id.ToString());
                    MessageBox.Show("Error inesperado. Compruebe su conexion o que seleccionó un deporte");
                    break;
            }
        }

        private void btnRefrescarDeportesEnSistema_Click(object sender, EventArgs e)
        {
            this.RefrescarDeportesEnSistema();
        }
    }
}
