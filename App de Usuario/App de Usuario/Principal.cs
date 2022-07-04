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

        private void veToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmDeportesFavoritos.Show();
            Program.frmDeportesFavoritos.MdiParent = this;
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmResultados.Show();
            Program.frmResultados.MdiParent = this;
        }

        private void verEventosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmEventosProgramados.Show();
            Program.frmEventosProgramados.MdiParent = this;
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmConfiguracion.Show();
            Program.frmConfiguracion.MdiParent = this;
        }
    }
}
