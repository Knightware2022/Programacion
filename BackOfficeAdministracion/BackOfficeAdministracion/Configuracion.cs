using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        private void caracteresContrasenia(byte opcion)
        {//1, es mostrar
            if (opcion == 1)
            {
                this.txtNuevaContraConfirma.UseSystemPasswordChar = false;
                this.txtNuevaContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtNuevaContraConfirma.UseSystemPasswordChar = true;
                this.txtNuevaContraseña.UseSystemPasswordChar = true;

            }
        }
        private void Configuracion_Load(object sender, EventArgs e)
        {
            this.txtNuevaContraConfirma.UseSystemPasswordChar = true;
            this.txtNuevaContraseña.UseSystemPasswordChar = true;
            this.txtContraActual.UseSystemPasswordChar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Visible = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Encriptacion en = new Encriptacion();
            if ((txtContraActual.Text.Equals("")) || (txtNuevaContraseña.Text.Equals("")))
            {
                
            }
            else {
                string contraseñaActual = txtContraActual.Text;
                string contraseñaNueva = txtNuevaContraseña.Text;
                string contraseñaConfirma = txtNuevaContraConfirma.Text;
                if (contraseñaConfirma == contraseñaNueva)
                {
                    contraseñaActual = en.encriptar(contraseñaActual);
                    if (Login.user.contrasenia == contraseñaActual)
                    {
                        if (!(contraseñaActual.Equals(contraseñaNueva)))
                        {
                            contraseñaNueva = en.encriptar(contraseñaNueva);
                            switch (Logica.modificarContraseña(Login.user.nombre, contraseñaNueva))
                            {
                                case 0:
                                    MessageBox.Show("Contraseña cambiada, vuelva a iniciar sesión");
                                    txtNuevaContraConfirma.Text = null;
                                    txtContraActual.Text = null;
                                    txtNuevaContraseña.Text = null;
                                    Program.frmPrincipal.Hide();
                                    Program.frmLogin.Show();
                                    break;
                                case 1:
                                    MessageBox.Show("Error de conexión");
                                    break;
                                case 2:
                                    MessageBox.Show("Error inesperado");
                                    break;
                            }
                        }
                        else {
                            MessageBox.Show("La contraseña nueva debe ser diferente a la actual");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esa no es su contraseña actual");
                    }
                }

                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void btnVer_MouseEnter(object sender, EventArgs e)
        {
            caracteresContrasenia(1);
        }

        private void btnVer_MouseLeave(object sender, EventArgs e)
        {
            caracteresContrasenia(0);
        }
    }
}
