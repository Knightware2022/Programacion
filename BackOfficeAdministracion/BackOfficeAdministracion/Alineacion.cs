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
    public partial class Alineacion : Form
    {
        public Alineacion()
        {
            InitializeComponent();
        }

        private void Alineacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.frmPrincipal.Enabled = true;

        }
    }
}
