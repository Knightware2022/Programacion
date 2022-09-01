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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            Logica.abrirConexion();
            this.paneOlvide.Visible = false;
            caracteresContrasenia(0);
            this.cmboxIdioma.Text = "Español";
            
        }

        private void caracteresContrasenia(byte opcion) {//1, es mostrar
            if (opcion == 1)
            {
                this.txtContrasenia.UseSystemPasswordChar = false;
               
            }
            else
            {
                this.txtContrasenia.UseSystemPasswordChar = true;
               
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Show();
            this.Hide();
        }

      

        private void chkboxOlvide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkboxOlvide_MouseClick(object sender, MouseEventArgs e)
        {
                this.paneIngresar.Visible = false;
                this.chkboxOlvide.Visible = false;
                this.chkboxOlvide.Checked = false;
                this.paneOlvide.Visible = true;

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            try
            {
                Logica._cn.Close();

            }
            catch {

            }

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //Logica.abrirConexion();
            Usuario u = new Usuario();
            Encriptacion encriptacion = new Encriptacion();
            u.nombre = txtUsuario.Text;
            u.contrasenia = encriptacion.encriptar(txtContrasenia.Text);
            switch(Logica.averiguandoRol(u)){
                case 0:
                    if (u.rol == 1)
                    {
                        switch (Logica.BuscandoUsuario(u))
                        {
                            case 0:
                                this.Hide();
                                Program.frmPrincipal.Show();
                                break;
                            case 1:
                                MessageBox.Show("Conexión no establecida");
                                break;
                            case 2:
                                MessageBox.Show("Ocurrió un error inesperado");
                                break;
                            case 3:
                            case 4:
                                MessageBox.Show("Usuario o contraseña invalidos");
                                txtContrasenia.Text = null;

                                break;
                        }
                    }
                    else {
                        MessageBox.Show("Usuario o contraseña inválidos");//en realidad existe, pero por un tema de "seguridad" no se muestra que es usuario y contra del cliente 
                        txtContrasenia.Text = null;

                    }
                    break;
                case 1:
                    MessageBox.Show("Conexión no establecida");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("Usuario o contraseña invalidos");//en realidad es que el usuariono existe
                    txtContrasenia.Text = null;
                    break;
            }
        }

        private void btnVerContrasenia_MouseEnter(object sender, EventArgs e)
        {
            caracteresContrasenia(1);

        }

        private void btnVerContrasenia_MouseLeave(object sender, EventArgs e)
        {
            caracteresContrasenia(0);

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarII_Click(object sender, EventArgs e)
        {
            this.paneIngresar.Visible = true;
            this.chkboxOlvide.Visible = true;
            this.paneOlvide.Visible = false;
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
