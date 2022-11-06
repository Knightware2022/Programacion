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
            switch (Logica.abrirConexion()) {
                case 1:
                    break;
                case 2:
                    MessageBox.Show("No se pudo conectar a la base de datos");
                    break;
            }
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
        public static Usuario user = new Usuario();

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Encriptacion encriptacion = new Encriptacion();
            user.nombre = txtUsuario.Text;
            user.contrasenia = encriptacion.encriptar(txtContrasenia.Text);
             switch(Logica.averiguandoRol(user)){
                 case 0:
                     if (user.rol == 1)
                     {
                         switch (Logica.BuscandoUsuario(user))
                         {
                             case 0:
                                 this.Hide();
                                 txtContrasenia.Text = null;
                                 txtCorreo.Text = null;
                                 txtUsuario.Text = null;
                                 Program.frmPrincipal.Show();
                                Program.frmPrincipal.btnGestionarDeportes.Enabled = true;
                                Program.frmPrincipal.btnGestionarEventos.Enabled = true;
                                Program.frmPrincipal.btnGestionarTorneos.Enabled = true;
                                Program.frmPrincipal.btnGestionarUsuarios.Enabled = true;
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
                        if (user.rol == 3) {
                            switch (Logica.BuscandoUsuario(user))
                            {
                                case 0:
                                    this.Hide();
                                    txtContrasenia.Text = null;
                                    txtCorreo.Text = null;
                                    txtUsuario.Text = null;
                                    Program.frmPrincipal.Show();
                                    Program.frmPrincipal.btnGestionarDeportes.Enabled = false;
                                    Program.frmPrincipal.btnGestionarEventos.Enabled = true;
                                    Program.frmPrincipal.btnGestionarTorneos.Enabled = true;
                                    Program.frmPrincipal.btnGestionarUsuarios.Enabled = false;

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
                    }
                     break;
                 case 1:
                     MessageBox.Show("Conexión no establecida");
                     break;
                 case 2:
                     MessageBox.Show("Ocurrió un error inesperado");
                     break;
                 case 3:
                     MessageBox.Show("Usuario o contraseña invalidos");//en realidad es que el usuario no existe
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
            Random r = new Random();
            string contra = null;
            Encriptacion en = new Encriptacion();
            int x, y;
            Usuario u = new Usuario();
            u.correo = txtCorreo.Text;
            switch (Logica.averiguarCorreo(u)) {
                case 0:
                    string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz@5#$%&##$/&)( ";
                    for (int i = 0; i < 8; i++)
                    {
                        x = r.Next((abecedario.Length -1 ));
                 //       y = x+ 1;
                        contra += abecedario.Substring(x, 1);
                    }
                    contra += r.Next(9999);
                    u.contrasenia = en.encriptar(contra);
                    switch (Logica.modificarContraseña(u.nombre, u.contrasenia)) {
                        case 0:
                            Mensajeria.sendCorreo(u.correo, contra);
                            MessageBox.Show("Una nueva contraseña fue enviada a su correo.");
                            break;
                        case 1:
                            MessageBox.Show("Error de conexión");
                            break;
                        case 2:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;
                     }
                    break;
                case 1:
                    MessageBox.Show("Error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("Error, correo no encontrado");
                    break;

            }
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

        private void chkboxOlvide_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
