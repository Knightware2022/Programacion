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
        private Color fondo;
        private Color letra;
        private Color boton;
        private Color casilla;

        public Configuracion()
        {
            InitializeComponent();
        }
       

        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {
            paneConfiguracion.BackColor = fondo;
            lblIdioma.ForeColor = letra;
            lblIdiomaE.ForeColor = letra;
            lblApariencia.ForeColor = letra;
            lblTema.ForeColor = letra;
            lblContra.ForeColor = letra;
            lblContraActual.ForeColor = letra;
            lblNuevaContra.ForeColor = letra;
            lblRepContra.ForeColor = letra;
            btnCambiarContraseña.BackColor = boton;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.FlatAppearance.BorderColor = boton;
            btnCambiarContraseña.ForeColor = letra;
            btnAplicar.BackColor = boton;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.FlatAppearance.BorderColor = boton;
            btnAplicar.ForeColor = letra;
            btnCerrar.BackColor = boton;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderColor = boton;
            btnCerrar.ForeColor = letra;
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
            cmboxIdioma.Text = cmboxIdioma.Items[0].ToString();
            cmboxTema.Text = cmboxTema.Items[0].ToString();

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
            Idiomas.CambioIdioma(cmboxIdioma.Text);
            int flag = 0;
            if (cmboxTema.SelectedItem.ToString() == "Oscuro")
            {
                fondo = Color.FromArgb(40, 40, 40);
                letra = Color.FromArgb(200, 200, 200);
                boton = Color.FromArgb(60, 60, 60);
                casilla = Color.FromArgb(70, 70, 70);
                flag = 2;
            }
            else
            {
                fondo = SystemColors.Control;
                letra = SystemColors.ControlText;
                boton = SystemColors.ButtonFace;
                casilla = SystemColors.Control;
                flag = 1;
            }
            Program.frmAlineacion.tema(fondo, letra, casilla, boton);
            Program.frmEncuentrosTorneos.tema(fondo, letra, casilla, boton);
            Program.frmGestionarDeportes.tema(fondo, letra, casilla, boton);
            Program.frmGestionarEventos.tema(fondo, letra, casilla, boton);
            Program.frmGestionarTorneos.tema(fondo, letra, casilla, boton);
            Program.frmGestionarUsuarios.tema(fondo, letra, casilla, boton);
            Program.frmIncidencias.tema(fondo, letra, casilla, boton);
            Program.frmPrincipal.tema(flag);
            tema(fondo, letra, casilla, boton);
        }

        private void btnVer_MouseEnter(object sender, EventArgs e)
        {
            caracteresContrasenia(1);
        }

        private void btnVer_MouseLeave(object sender, EventArgs e)
        {
            caracteresContrasenia(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void paneConfiguracion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            Encriptacion en = new Encriptacion();
            if ((txtContraActual.Text.Equals("")) || (txtNuevaContraseña.Text.Equals("") || txtNuevaContraseña.Text.Count() < 5))
            {
                MessageBox.Show("La contraseña nueva debe tener mas de 5 caracteres");
            }
            else
            {
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
                        else
                        {
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
    }
}
