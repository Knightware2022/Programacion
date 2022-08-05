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
    public partial class EventosProgramados : Form
    {
        public EventosProgramados()
        {
            InitializeComponent();
        }

        private void EventosProgramados_Load(object sender, EventArgs e)
        {
            this.Size = Program.frmPrincipal.paneVentanas.Size;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnAvisarme1_Click(object sender, EventArgs e)
        {
            btnAvisarme1.Text = Idiomas.cambiarBotonAvisame(btnAvisarme1.Text);
        }

        private void btnAvisarme2_Click(object sender, EventArgs e)
        {
            btnAvisarme2.Text = Idiomas.cambiarBotonAvisame(btnAvisarme2.Text);

        }

        private void btnAvisarme3_Click(object sender, EventArgs e)
        {
            btnAvisarme3.Text = Idiomas.cambiarBotonAvisame(btnAvisarme3.Text);

        }

        private void btnAvisarme4_Click(object sender, EventArgs e)
        {
            btnAvisarme4.Text = Idiomas.cambiarBotonAvisame(btnAvisarme4.Text);

        }
    }
}
