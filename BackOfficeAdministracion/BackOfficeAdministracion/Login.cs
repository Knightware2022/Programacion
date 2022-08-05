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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.paneOlvide.Visible = false;

        }

        private void chkboxOlvide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkboxOlvide_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.chkboxOlvide.Checked == true)
            {
                this.paneOlvide.Visible = true;

            }
            else
            {
                this.paneOlvide.Visible = false;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
