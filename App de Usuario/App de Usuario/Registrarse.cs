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
                            this.Hide();
                            Program.frmPrincipal.paneVentanas.Show();
                            Program.frmLogin = new Login();
                            Program.frmLogin.Show();
                            Program.frmPrincipal.Hide();
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
                else {
                    MessageBox.Show("Dirección de correo no válida");
                }
            }
            else {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }
    }
}
