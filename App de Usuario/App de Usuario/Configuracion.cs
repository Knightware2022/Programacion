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
        public static Color formulario;
        public static Color boton;
        public static Color letra;
        public static Color casilla;
        public static Color panel1;
        public static Color panel2;
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
            correo = txtCorreo.Text;
        }
         private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void btnCambiarAvatar_Click(object sender, EventArgs e)
        {

            string avatar = cmboxAvatares.Text;
            if (avatar.Equals("Femenino") || avatar.Equals("Woman"))
            {
                pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarFemenino;
                if (Properties.Resources.GuardarAvatar.Contains('1'))
                {
                    Properties.Resources.nombreAvatar.Replace('1', '2');
                    Properties.Resources.GuardarAvatar.Replace('1', '2');
                }
                else
                {
                    if (Properties.Resources.GuardarAvatar.Contains("0"))
                    {
                        Properties.Resources.GuardarAvatar.Replace('0', '2');
                        Properties.Resources.nombreAvatar.Remove(0);
                        Properties.Resources.nombreAvatar.Insert(0, "1");
                    }
                }
            }
            else
            {
                if (avatar.Equals("Masculino") || avatar.Equals("Man"))
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarMasculino;
                    if (Properties.Resources.GuardarAvatar.Contains('2'))
                    {
                        Properties.Resources.GuardarAvatar.Replace('2', '1');
                    }
                    else {
                        if (Properties.Resources.GuardarAvatar.Contains('0')) {
                            Properties.Resources.GuardarAvatar.Replace('0', '1');
                        }
                    }

                }
                else
                {
                    pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
                    if (Properties.Resources.GuardarAvatar.Contains('2'))
                    {
                        Properties.Resources.GuardarAvatar.Replace('2', '0');
                    }
                    else
                    {
                        if (Properties.Resources.GuardarAvatar.Contains('1'))
                        {
                            Properties.Resources.GuardarAvatar.Replace('1', '0');
                        }
                    }
                }
            }

        }
        public void temaActualizar()
        {
            if (cmboxTema.SelectedItem.ToString() == "Oscuro" || cmboxTema.SelectedItem.ToString() == "Dark")
            {
                formulario = Color.FromArgb(30, 30, 30);
                panel1 = Color.FromArgb(50, 50, 50);
                panel2 = Color.FromArgb(70, 70, 70);
                boton = Color.FromArgb(60, 60, 60);
                letra = Color.FromArgb(200, 200, 200);
            }
            else
            {
                formulario = SystemColors.ActiveCaption;
                panel1 = SystemColors.GradientActiveCaption;
                panel2 = SystemColors.GradientInactiveCaption;
                boton = System.Drawing.Color.LightGray;
                letra = SystemColors.ControlText;
            }

            tema(formulario, boton, letra, panel1, panel2);
            Program.frmResultados.temaResul(formulario, boton, letra, panel1, panel2);
            Program.frmPrincipal.temaPrincipal(formulario, boton, letra, panel1, panel2);
            Program.frmLogin.temaLogin(formulario, boton, letra, panel1, panel2);
            Program.frmDeportesFavoritos.temaDepoFav(formulario, boton, letra, panel1, panel2);
            Program.frmEventosProgramados.temaEvenProg(formulario, boton, letra, panel1, panel2);
            Program.frmAlineacion.temaAli(formulario, boton, letra, panel1, panel2);
            Program.frmTorneosProgramados.temaTorProg(formulario, boton, letra, panel1, panel2);
            Program.frmIncidencias.temaInci(formulario, boton, letra, panel1, panel2);
            Program.frmRegistrarse.temaRegis(formulario, boton, letra, panel1, panel2);
        }
        public void tema(Color formulario, Color boton, Color letra, Color panel1, Color panel2)
        {
            this.BackColor = formulario;
            panePerfil.BackColor = panel2;
            lblPerfil.ForeColor = letra;
            lblNombreUsuario.ForeColor = letra;
            lblContrasenia.ForeColor = letra;
            btnCambiarContrasenia.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasenia.BackColor = boton;
            btnCambiarContrasenia.ForeColor = letra;
            btnCambiarContrasenia.FlatAppearance.BorderColor = boton;
            lblCorreoElectronico.ForeColor = letra;
            btnCambiarCorreo.FlatStyle = FlatStyle.Flat;
            btnCambiarCorreo.BackColor = boton;
            btnCambiarCorreo.ForeColor = letra;
            btnCambiarCorreo.FlatAppearance.BorderColor = boton;
            lblAvatar.ForeColor = letra;
            btnCambiarAvatar.FlatStyle = FlatStyle.Flat;
            btnCambiarAvatar.BackColor = boton;
            btnCambiarAvatar.ForeColor = letra;
            btnCambiarAvatar.FlatAppearance.BorderColor = boton;
            paneApariencia.BackColor = panel2;
            lblApariencia.ForeColor = letra;
            lblTema.ForeColor = letra;
            paneIdioma.BackColor = panel2;
            lblIdioma.ForeColor = letra;
            lblSeleccioneIdioma.ForeColor = letra;
            btnAplicarCambios.FlatStyle = FlatStyle.Flat;
            btnAplicarCambios.BackColor = boton;
            btnAplicarCambios.ForeColor = letra;
            btnAplicarCambios.FlatAppearance.BorderColor = boton;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.BackColor = boton;
            btnCancelar.ForeColor = letra;
            btnCancelar.FlatAppearance.BorderColor = boton;

        }
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            temaActualizar(); //Debe ser la primera linea del void
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
        private string correo;
        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            ApiAutentificacion api = new ApiAutentificacion();
            DialogResult cambioPasword;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraNueva = Microsoft.VisualBasic.Interaction.InputBox(Idiomas.nuevaContra, Idiomas.tituloMessageBoxContra) ;
            string confirmar = Microsoft.VisualBasic.Interaction.InputBox(Idiomas.confirmarContraseña, Idiomas.tituloMessageBoxContra);
            cambioPasword = MessageBox.Show(Idiomas.confirmarContraCambio, Idiomas.tituloMessageBoxContra, MessageBoxButtons.YesNo);
            if (cambioPasword == DialogResult.Yes) {
                switch (api.cambiarContrasenia(nombreUsuario, contraNueva, confirmar)) {
                    case 0:
                        MessageBox.Show(Idiomas.contraCambiada);
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errorConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.contraseñasNoCoinciden);
                        break;
                }
            }
            else {
                MessageBox.Show(Idiomas.cancelacionCambioContra);
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarCorreo_Click(object sender, EventArgs e)
        {
            string correoNuevo = txtCorreo.Text;
            if (correoNuevo.Contains("@") && correoNuevo.Contains(".com") && correoNuevo.Count() >= 7)
            {
                switch (ApiAutentificacion.cambiarCorreo(correoNuevo, Login.nombreUsuario))
                {
                    case 0:
                        MessageBox.Show(Idiomas.correoCambiado);
                        txtCorreo.Text = correoNuevo;
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errorConexion);
                        break;
                    case 2:
                    case 4:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.CorreoEnuso);
                        txtCorreo.Text = correo;
                        break;
                }
            }
            else {
                MessageBox.Show(Idiomas.CorreoNOVALIDO);
                    txtCorreo.Text = correo;
            }
            
        }
    }
}
