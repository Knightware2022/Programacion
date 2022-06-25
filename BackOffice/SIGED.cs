using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class SIGED : Form
    {
        public SIGED()
        {
            InitializeComponent();
        }

        private void SIGED_Load(object sender, EventArgs e)
        {
            picbxImagenHome.Image =  System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\ProyectoProg\HOME.png");
            this.IsMdiContainer = true;
            
        }

        private void btnGEventos_Click(object sender, EventArgs e)
        {
            Program.frmGestionarEventos.Show();
            Program.frmGestionarEventos.MdiParent = this;
            paneVista.Hide();
            Program.frmGestionarEventos.Location = paneVista.Location;
        }

        private void paneVista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGUsuarios_Click(object sender, EventArgs e)
        {
            Program.frmGestionarUsuarios.Show();
            Program.frmGestionarUsuarios.MdiParent = this;
            paneVista.Hide();
            Program.frmGestionarUsuarios.Location = paneVista.Location;
        }

        private void btnGDeportes_Click(object sender, EventArgs e)
        {
            Program.frmGestionarDeportes.Show();
            Program.frmGestionarDeportes.MdiParent = this;
            paneVista.Hide();
            Program.frmGestionarDeportes.Location = paneVista.Location;
        }
    }
}
