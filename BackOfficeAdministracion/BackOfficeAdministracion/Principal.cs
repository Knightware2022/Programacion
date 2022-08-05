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
            this.paneVista.Hide();
            Program.frmGestionarDeportes.Show();
            Program.frmGestionarDeportes.MdiParent = this;
            Program.frmGestionarDeportes.Location = this.paneVista.Location;
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarUsuarios.Show();
            Program.frmGestionarUsuarios.MdiParent = this;
            Program.frmGestionarUsuarios.Location = this.paneVista.Location;
        }

        private void btnGestionarEventos_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarEventos.Show();
            Program.frmGestionarEventos.MdiParent = this;
            Program.frmGestionarEventos.Location = this.paneVista.Location;
            
        }
        
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmConfiguracion.Show();
            Program.frmConfiguracion.MdiParent = this;
            Program.frmConfiguracion.Location = this.paneVista.Location;
          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//cierra todo
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
