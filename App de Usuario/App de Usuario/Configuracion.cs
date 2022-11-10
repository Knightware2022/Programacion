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
            ApiAutentificacion api = new ApiAutentificacion();
            this.Size = Program.frmPrincipal.paneVentanas.Size;
            this.cmboxAvatares.Text ="Estándar";
            this.cmboxIdiomas.Text = Program.frmLogin.cmboxIdioma.Text;
            this.cmboxTema.Text = "Predeterminado";
            txtContrasenia.Text = "XXXXXXXXXXXXXX";
            txtNombreUsuario.Text = Login.nombreUsuario;
            txtCorreo.Text = api.correo(Login.nombreUsuario);
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
                if (Properties.Resources.GuardarAvatar.Contains("1"))
                {
                    Properties.Resources.GuardarAvatar.Replace("1", "2");
                }
                else
                {
                    if (Properties.Resources.GuardarAvatar.Contains("0"))
                    {
                        Properties.Resources.GuardarAvatar.Replace("0", "2");
                    }
                }
            }
            else
            {
                if (avatar.Equals("Masculino"))
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarMasculino;
                    if (Properties.Resources.GuardarAvatar.Contains("2"))
                    {
                        Properties.Resources.GuardarAvatar.Replace("2", "1");
                    }
                    else {
                        if (Properties.Resources.GuardarAvatar.Contains("0")) {
                            Properties.Resources.GuardarAvatar.Replace("0", "1");
                        }
                    }

                }
                else
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
                    if (Properties.Resources.GuardarAvatar.Contains("2"))
                    {
                        Properties.Resources.GuardarAvatar.Replace("2", "0");
                    }
                    else
                    {
                        if (Properties.Resources.GuardarAvatar.Contains("1"))
                        {
                            Properties.Resources.GuardarAvatar.Replace("1", "0");
                        }
                    }
                }
            }
        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.btnAvatar.BackgroundImage = pboxAvatar.Image;
           /* int avatar = Convert.ToInt32(global::App_de_Usuario.Properties.Resources.GuardarAvatar);
            if (avatar == 0)
            {//avatar por defecto
                Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
            }
            else
            {
                if (avatar == 1)//avatar masculino
                {
                    Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarMasculino;

                }
                else
                {
                    Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarFemenino;

                }
            }*/
            string idioma = cmboxIdiomas.SelectedItem.ToString();
            Idiomas.cambiarIdioma(idioma);

        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            ApiAutentificacion api = new ApiAutentificacion();
            DialogResult cambioPasword;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraNueva = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su nueva contraseña", "Cambio de contraseña") ;
            string confirmar = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nuevamente la nueva contraseña", "Cambio de contraseña");
            cambioPasword = MessageBox.Show("Está seguro que desea cambiar su contraseña?", "Cambio de contraseña", MessageBoxButtons.YesNo);
            if (cambioPasword == DialogResult.Yes) {
                switch (api.cambiarContrasenia(nombreUsuario, contraNueva, confirmar)) {
                    case 0:
                        MessageBox.Show("Contraseña cambiada");
                        break;
                    case 1:
                        MessageBox.Show("Ocurrió un error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("Las contraseñas no coinciden");
                        break;
                }
            }
            else {
                MessageBox.Show("Cambio de contraseña cancelado");
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
