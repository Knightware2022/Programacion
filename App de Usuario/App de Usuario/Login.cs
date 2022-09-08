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
                    int yBase = Program.frmPrincipal.paneVentanas.Size.Height;
                    yBase += Program.frmPrincipal.pboxPublicidad.Size.Height;
                    int xBase = Program.frmPrincipal.pboxPublicidad.Size.Width;
                    Program.frmPrincipal.paneVentanas.Size = new System.Drawing.Size(xBase, yBase);
                    Program.frmPrincipal.Show();
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
                    break;
                case 1://conexion cerrada
                    MessageBox.Show("Ocurrió un problema de conexión");
                    break;
                case 2:
                    MessageBox.Show("Ocurrio un error inesperado");
                    break;
                case 3: case 4:
                    MessageBox.Show("Usuario o contraseña incorrectos"); 
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
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
            this.txtRegistrarContrasenia.UseSystemPasswordChar = true;
            this.cmboxIdioma.Text = "Español";
            this.cmboxCambiarIdiomaII.Text = "Español";
            Idiomas.cambiarIdioma(cmboxCambiarIdiomaII.Text);
            Logica.abrirConexion();
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
            this.Hide();
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
                            MessageBox.Show("Se ha registrado exitosamente. Inicie Sesión");
                            this.paneIngreso.Visible = true;
                            this.paneRegistrarse.Visible = false;
                            break;
                        case 1:
                            MessageBox.Show("Error de conexión");
                            break;
                        case 2:
                        case 3:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;
                        case 4:
                            MessageBox.Show("Este usuario ya existe");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Dirección de correo no válida");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        
    }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Logica._cn.Close();
            }
            catch {
            }
        }
    }
}
