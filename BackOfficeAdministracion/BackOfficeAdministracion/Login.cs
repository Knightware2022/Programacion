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
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.Show();
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
    }
}
