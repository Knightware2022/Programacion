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
    public partial class GestionarDeportes : Form
    {
        public GestionarDeportes()
        {
            InitializeComponent();
        }
        private void cerrar() {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

        private void btnCerrarI_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();

        }
    }
}
