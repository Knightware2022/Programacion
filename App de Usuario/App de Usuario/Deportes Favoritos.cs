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
            this.Visible = false;
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
                        MessageBox.Show(Idiomas.ErrorEquiposNOHAYSISTEMA);
                    }
                    break;
                default:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
            }
        }
        private void refrescarFavoritos()
        {

            List<string> listaDeportesFavo = new List<string>();
            switch (ApiResultados.obtenerDeportesFavoritos(listaDeportesFavo))
            {
                case 0:
                    cmboxDeportesFavoritos.Items.Clear();
                    foreach (string nombre in listaDeportesFavo)
                    {
                        cmboxDeportesFavoritos.Items.Add(nombre);
                    }
                    try
                    {
                        cmboxDeportesFavoritos.Text = listaDeportesFavo[0];

                    }
                    catch
                    {
                        MessageBox.Show(Idiomas.noPoseeDeportesFav);
                    }
                    break;
                default:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
            }
        }
        private void refrescarEquiposFavoritos()
        {

            List<string> listaEquiposFav = new List<string>();
            switch (ApiResultados.obtenerEquiposFavoritos(Login.nombreUsuario, listaEquiposFav))
            {
                case 0:
                    cmboxEquiFAv.Items.Clear();
                    foreach (string nombre in listaEquiposFav)
                    {
                        cmboxEquiFAv.Items.Add(nombre);
                    }
                    try
                    {
                        cmboxEquiFAv.Text = listaEquiposFav[0];

                    }
                    catch
                    {
                        MessageBox.Show(Idiomas.noPoseeEquiposFav);
                    }
                    break;
                default:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
            }
        }
        private void RefrescarEquiposSistemaa()
        {

            List<string> listaEquipos = new List<string>();
            switch (ApiResultados.obtenerEquiposEnSistema(listaEquipos))
            {
                case 0:
                    cmboxEquiSistem.Items.Clear();
                    foreach (string nombre in listaEquipos)
                    {
                        cmboxEquiSistem.Items.Add(nombre);
                    }
                    try
                    {
                        cmboxEquiSistem.Text = listaEquipos[0];

                    }
                    catch
                    {
                        MessageBox.Show(Idiomas.ErrorEquiposNOHAYSISTEMA);
                    }
                    break;
                default:
                    MessageBox.Show(Idiomas.errorConexion);
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
                    MessageBox.Show(Idiomas.yanoSigueaDeporteEquipo);
                    this.refrescarFavoritos();
                    break;
                default:
                    MessageBox.Show(Idiomas.errorCompruebeDatos);
                    break;
            }
        }

        private void btnAgregarDeporteFavorito_Click(object sender, EventArgs e)
        {

            switch (ApiResultados.AgregarDeportesFavoritos(cmboxDeportes.Text))
            {
                case 0:
                    MessageBox.Show(Idiomas.siguesaDeporte);
                    this.refrescarFavoritos();
                    break;
                default:
                    MessageBox.Show(ApiResultados.usuario.id.ToString());
                    MessageBox.Show(Idiomas.errorCompruebeDatos);
                    break;
            }
        }

        private void btnRefrescarDeportesEnSistema_Click(object sender, EventArgs e)
        {
            this.RefrescarDeportesEnSistema();
        }

        private void btnRefrescarEqui_Click(object sender, EventArgs e)
        {
            this.refrescarEquiposFavoritos();
            this.RefrescarEquiposSistemaa();

        }

        private void btnEquiposFav_Click(object sender, EventArgs e)
        {
        }

        private void btnEquiposNoFAv_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = cmboxEquiFAv.Text.Substring(0, cmboxEquiFAv.Text.IndexOf("/"));
                string categoria = cmboxEquiFAv.Text.Substring((cmboxEquiFAv.Text.IndexOf("/") + 1), (cmboxEquiFAv.Text.Length - (cmboxEquiFAv.Text.IndexOf("/") + 1)));
                switch (ApiResultados.EliminarEquiposFavoritos(nombre, categoria, Login.nombreUsuario))
                {
                    case 0:
                        MessageBox.Show(Idiomas.yanoSigueaDeporteEquipo);
                        this.refrescarEquiposFavoritos();
                        break;
                    default:
                        MessageBox.Show(Idiomas.errorCompruebeDatos);
                        break;
                }


            }
            catch
            {
                MessageBox.Show(Idiomas.ErrorObteniendoID);

            }
        }
    }
}
