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
    public partial class GestionarEventos : Form
    {
        public GestionarEventos()
        {
            InitializeComponent();
        }

        private void cerrar() {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

       

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Program.frmIncidencias.Visible = true;
        }

        private void btnIncidenciasIndividuales_Click(object sender, EventArgs e)
        {
            Program.frmIncidenciasIndividuales.Visible = true;
            
        }
    }
}
