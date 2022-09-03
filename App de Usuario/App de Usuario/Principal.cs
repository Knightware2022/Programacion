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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e){
            this.IsMdiContainer = true;
            ApiPublicidad publicidad = new ApiPublicidad();
            publicidad.obtenerPublicidad(1234);
            if (publicidad.publicidad.url == "Error34X_Publicidad") {
            }
            else {
                try
                {
                    var request = WebRequest.Create(publicidad.publicidad.url);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pboxPublicidad.Image = Bitmap.FromStream(stream);
                    }
                }
                catch {
                 
                    this.pboxPublicidad.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
                }
            }
        }

        


        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
                Logica._cn.Close();
            }
            catch {

            }

          
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Program.frmResultados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmResultados.Show();
            Program.frmResultados.Bounds = paneVentanas.Bounds;

        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            Program.frmEventosProgramados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmEventosProgramados.Show();
            Program.frmEventosProgramados.Bounds = paneVentanas.Bounds;
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Program.frmDeportesFavoritos.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmDeportesFavoritos.Show();
            Program.frmDeportesFavoritos.Bounds = paneVentanas.Bounds;

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            Program.frmConfiguracion.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmConfiguracion.Show();
            Program.frmConfiguracion.Bounds = paneVentanas.Bounds;
           
        }

        private void pboxPublicidad_Click(object sender, EventArgs e)
        {
            Program.frmRegistrarse.MdiParent = this;
            Program.frmRegistrarse.Show();
            paneVentanas.Visible = false;
            Program.frmRegistrarse.Bounds = paneVentanas.Bounds;

        }
    }
}
