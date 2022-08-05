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

        private void Configuracion_Load(object sender, EventArgs e)
        {

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
    }
}
