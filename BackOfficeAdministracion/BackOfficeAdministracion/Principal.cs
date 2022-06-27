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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnGestionarDeportes_Click(object sender, EventArgs e)
        {
            Program.frmGestionarDeportes.MdiParent = this;
            Program.frmGestionarDeportes.Location = this.paneVista.Location;
            Program.frmGestionarDeportes.Show();
            this.paneVista.Hide();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            Program.frmGestionarUsuarios.MdiParent = this;
            Program.frmGestionarUsuarios.Location = this.paneVista.Location;
            Program.frmGestionarUsuarios.Show();
            this.paneVista.Hide();
        }

        private void btnGestionarEventos_Click(object sender, EventArgs e)
        {
            Program.frmGestionarEventos.MdiParent = this;
            Program.frmGestionarEventos.Location = this.paneVista.Location;
            Program.frmGestionarEventos.Show();
            this.paneVista.Hide();
        }
    }
}
