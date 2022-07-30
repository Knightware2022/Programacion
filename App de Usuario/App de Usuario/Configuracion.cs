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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;
            this.cmboxAvatares.Text ="Estándar";
            this.cmboxIdiomas.Text = Program.frmLogin.cmboxIdioma.Text;
            this.cmboxTema.Text = "Predeterminado";

        }
         private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCambiarAvatar_Click(object sender, EventArgs e)
        {
            string avatar = cmboxAvatares.SelectedItem.ToString();
            if (avatar.Equals("Femenino")) {
                pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarFemenino;
            }
            else
            {
                if (avatar.Equals("Masculino"))
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarMasculino;
                }
                else
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
                }
            }
        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.btnAvatar.BackgroundImage = pboxAvatar.Image;
            string idioma = cmboxIdiomas.SelectedItem.ToString();
            Idiomas.cambiarIdioma(idioma);
        }
    }
}
