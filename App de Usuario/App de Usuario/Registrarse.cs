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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;
            this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
            this.txtRegistrarContrasenia.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnVerContrasenia_MouseEnter(object sender, EventArgs e)
        {
            this.txtConfirmarContrasenia.UseSystemPasswordChar = false;
            this.txtRegistrarContrasenia.UseSystemPasswordChar = false;
        }

        private void btnVerContrasenia_MouseLeave(object sender, EventArgs e)
        {
            this.txtConfirmarContrasenia.UseSystemPasswordChar = true;
            this.txtRegistrarContrasenia.UseSystemPasswordChar = true;
        }
        public void temaRegis(Color formulario, Color panel1, Color panel2, Color boton, Color letra)
        {
            this.BackColor = formulario;

            AtxtPromo.BackColor = panel1;
            AtxtPromo.ForeColor = letra;

            paneRegistrarse.BackColor = panel2;

            lblConfirmarContrasenia.ForeColor = letra;
            lblCorreo.ForeColor = letra;
            lblNombreUsuario.ForeColor = letra;
            lblRegistroUsuario.ForeColor = letra;

            btnCancelar.BackColor = boton;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderColor = boton;
            btnCancelar.ForeColor = letra;
            btnRegistro.BackColor = boton;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.FlatAppearance.BorderColor = boton;
            btnRegistro.ForeColor = letra;
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
                            this.Hide();
                            Program.frmPrincipal.paneVentanas.Show();
                            Program.frmLogin = new Login();
                            Program.frmLogin.Show();
                            Program.frmPrincipal.Hide();
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
                else {
                    MessageBox.Show(Idiomas.CorreoNOVALIDO);
                }
            }
            else {
                MessageBox.Show(Idiomas.contraseñasNoCoinciden);
            }

        }
    }
}
