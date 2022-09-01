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

        }
    }
}
