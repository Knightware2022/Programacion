﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string nombreUsuario;
        public static string mac = "";
        public static int idUsuario;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ApiAutentificacion apiA = new ApiAutentificacion();
            String nombre = txtUsuario.Text;
            int avatar;
            byte respuesta = apiA.iniciarSesion(nombre, txtContrasenia.Text);
            switch (respuesta){
                case 0://encontro      
                    this.Hide();
                    Program.frmPrincipal.pboxPublicidad.Hide();
                    Program.frmPrincipal.paneBanner.Hide();
                    //int yBase = Program.frmPrincipal.paneVentanas.Size.Height;
                   // yBase += Program.frmPrincipal.pboxPublicidad.Size.Height;
                    //int xBase = Program.frmPrincipal.pboxPublicidad.Size.Width;
                   // Program.frmPrincipal.paneVentanas.Size = new System.Drawing.Size(xBase, yBase);
                    Program.frmPrincipal.Show();
                    txtUsuario.Text = null;
                    txtRegistrarUsuario.Text = null;
                    txtRegistrarContrasenia.Text = null;
                    txtOlvide.Text = null;
                    txtCorreo.Text = null;
                    txtContrasenia.Text = null;
                    txtConfirmarContrasenia.Text = null;
                    List<string> algo = new List<string>();
                    ApiResultados.obtenerDeportesFavoritos(algo);
                    /* avatar = Convert.ToInt32(global::App_de_Usuario.Properties.Resources.GuardarAvatar);
                     if (avatar == 0) {//avatar por defecto
                         Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
                     }
                     else
                     {
                         if (avatar == 1)//avatar masculino
                         {
                             Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarMasculino;

                         }
                         else {
                             Program.frmPrincipal.btnAvatar.Image = global::App_de_Usuario.Properties.Resources.avatarFemenino;

                         }
                     }*/
                    Program.frmPrincipal.btnAvatar.Enabled = true;
                    Program.frmPrincipal.btnTorneos.Enabled = true;
                    Program.frmPrincipal.btnEncuentros.Enabled = true;
                    Program.frmPrincipal.btnFavoritos.Enabled = true;

                    nombreUsuario = nombre;
                    break;
                case 1://conexion cerrada
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3: case 4:
                    MessageBox.Show(Idiomas.UsuarioOContraseñaInvalidos); 
                    break;
            }

        }

        private void caracteresContrasenia(byte opcion) {//1, es mostrar
            if (opcion == 1)
            {
                this.txtContrasenia.UseSystemPasswordChar = false;
                this.txtConfirmarContrasenia.UseSystemPasswordChar = false;
                this.txtRegistrarContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtContrasenia.UseSystemPasswordChar = true;
                this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
                this.txtRegistrarContrasenia.UseSystemPasswordChar = true;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.paneRegistrarse.Visible = false;
            this.paneRegistrarse.Location = new Point(14, 55);
            this.paneIngreso.Visible = true;
            this.paneIngreso.Location = new Point(14, 79) ;
            this.paneOlvide.Location = new Point(14, 79);
            paneOlvide.Visible = false;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
            this.txtRegistrarContrasenia.UseSystemPasswordChar = true;
            this.cmboxIdioma.Text = "Español";
            this.cmboxCambiarIdiomaII.Text = "Español";
            Idiomas.cambiarIdioma(cmboxCambiarIdiomaII.Text);
            switch (Logica.abrirConexion()) {
                case 1:
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorConexion);
                    Application.Exit();
                    break;
            }
        }
        


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.paneIngreso.Visible = false;
            this.paneRegistrarse.Visible = true;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.paneIngreso.Visible = true;
            this.paneRegistrarse.Visible = false;
            txtUsuario.Text = null;
            txtRegistrarUsuario.Text = null;
            txtRegistrarContrasenia.Text = null;
            txtOlvide.Text = null;
            txtCorreo.Text = null;
            txtContrasenia.Text = null;
            txtConfirmarContrasenia.Text = null;
        }

        private void btnVerContrasenia_Leave(object sender, EventArgs e)
        {
            this.caracteresContrasenia(0);
        }

        private void btnVerContrasenia_Enter(object sender, EventArgs e)
        {
            this.caracteresContrasenia(1);
        }


        private void btnGuest_Click(object sender, EventArgs e)
        {
            List<string> macs = new List<string>();
            this.Hide();
            switch (Program.apiA.entrarComoGuest(macs)) {
                case 0:
                    mac = macs[0];
                    break;
                case 3:
                    MessageBox.Show(Idiomas.BienvenidaGuest);
                    break;
            }
            Program.frmPrincipal.btnAvatar.Enabled = false;
            Program.frmPrincipal.btnTorneos.Enabled = false;
            Program.frmPrincipal.btnEncuentros.Enabled = false;
            Program.frmPrincipal.btnFavoritos.Enabled = false;

            Program.frmPrincipal.Show();
        }

        private void cmboxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idioma = cmboxIdioma.SelectedItem.ToString();
            Idiomas.cambiarIdioma(idioma);
        }

        private void cmboxCambiarIdiomaII_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idioma = cmboxCambiarIdiomaII.SelectedItem.ToString();
            Idiomas.cambiarIdioma(idioma);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Encriptacion encriptacion = new Encriptacion();
            string contrasenia = txtRegistrarContrasenia.Text;
            string confirmarContrasenia = txtConfirmarContrasenia.Text;
            string correo = txtCorreo.Text;
            string nombre = txtRegistrarUsuario.Text;
            if (contrasenia.Equals(confirmarContrasenia))
            {
                if (correo.Contains("@") && correo.Contains(".com"))
                {
                    contrasenia = encriptacion.encriptar(contrasenia);
                    switch (Program.apiA.Registrarse(nombre, contrasenia, correo))
                    {
                        case 0://logró registrarse
                            MessageBox.Show(Idiomas.RegistroExitoso);
                            this.paneIngreso.Visible = true;
                            this.paneRegistrarse.Visible = false;
                            txtUsuario.Text = null;
                            txtRegistrarUsuario.Text = null;
                            txtRegistrarContrasenia.Text = null;
                            txtOlvide.Text = null;
                            txtCorreo.Text = null;
                            txtContrasenia.Text = null;
                            txtConfirmarContrasenia.Text = null;
                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errorConexion);
                            break;
                        case 2:
                        case 3:
                            MessageBox.Show(Idiomas.errorInesperado);
                            break;
                        case 4:
                            MessageBox.Show(Idiomas.usuarioExiste);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.CorreoNOVALIDO);
                }
            }
            else
            {
                MessageBox.Show(Idiomas.contraseñasNoCoinciden);
            }

        
    }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
                Logica._cn.Close();
            }
            catch {
            }
        }

        private void chkboxOlvide_MouseClick(object sender, MouseEventArgs e)
        {
            paneIngreso.Visible = false;
            chkboxOlvide.Checked = false;
            paneOlvide.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarContraseña_Click(object sender, EventArgs e)
        {
            paneOlvide.Visible = false;
            paneIngreso.Visible = true;
            txtUsuario.Text = null;
            txtRegistrarUsuario.Text = null;
            txtRegistrarContrasenia.Text = null;
            txtOlvide.Text = null;
            txtCorreo.Text = null;
            txtContrasenia.Text = null;
            txtConfirmarContrasenia.Text = null;
        }


        public void temaLogin(Color formulario, Color boton, Color letra, Color panel1, Color panel2)
        {
            this.BackColor = formulario;
            paneIngreso.BackColor = panel1;
            lblCambiarIdiomaII.ForeColor = letra;
            lblUsuario.ForeColor = letra;
            lblContrasenia.ForeColor = letra;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderColor = boton;
            btnIngresar.BackColor = boton;
            btnIngresar.ForeColor = letra;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.FlatAppearance.BorderColor = boton;
            btnRegistrarse.BackColor = boton;
            btnRegistrarse.ForeColor = letra;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.FlatAppearance.BorderColor = boton;
            btnGuest.BackColor = boton;
            btnGuest.ForeColor = letra;
            chkboxOlvide.ForeColor = letra;

            paneOlvide.BackColor = panel1;
            lblOlvide.ForeColor = letra;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.FlatAppearance.BorderColor = boton;
            btnEnviar.BackColor = boton;
            btnEnviar.ForeColor = letra;
            btnCancelarContraseña.FlatStyle = FlatStyle.Flat;
            btnCancelarContraseña.FlatAppearance.BorderColor = boton;
            btnCancelarContraseña.BackColor = boton;
            btnCancelarContraseña.ForeColor = letra;

            paneRegistrarse.BackColor = panel1;
            lblCambiarIdioma.ForeColor = letra;
            lblNombreUsuario.ForeColor = letra;
            lblContrasenia.ForeColor = letra;
            lblConfirmarContrasenia.ForeColor = letra;
            lblCorreo.ForeColor = letra;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.FlatAppearance.BorderColor = boton;
            btnRegistro.BackColor = boton;
            btnRegistro.ForeColor = letra;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderColor = boton;
            btnCancelar.BackColor = boton;
            btnCancelar.ForeColor = letra;
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = txtOlvide.Text;
            switch (Program.apiA.olvideContrasenia(correo)){
                case 0:
                    MessageBox.Show(Idiomas.nuevaContraseña);
                    paneOlvide.Visible = false;
                    txtUsuario.Text = null;
                    txtRegistrarUsuario.Text = null;
                    txtRegistrarContrasenia.Text = null;
                    txtOlvide.Text = null;
                    txtCorreo.Text = null;
                    txtContrasenia.Text = null;
                    txtConfirmarContrasenia.Text = null;
                    paneIngreso.Visible = true;
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errorConexion);

                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);

                    break;
                case 3:
                    MessageBox.Show(Idiomas.CorreoNotFound);

                    break;

            }

        }
    }
}
