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
            if (btnAvisarme1.Text.Equals("Notify") || btnAvisarme1.Text.Equals("Avísame"))
            {
                btnAvisarme1.Text = "No me avises";
            }
            else {
                btnAvisarme1.Text = "Avísame";
            }
            btnAvisarme1.Text = Idiomas.cambiarIdiomaBotonAvisame(btnAvisarme1.Text);

        }

        private void btnAvisarme2_Click(object sender, EventArgs e)
        {
            if (btnAvisarme2.Text.Equals("Notify") || btnAvisarme2.Text.Equals("Avísame"))
            {
                btnAvisarme2.Text = "No me avises";
            }
            else
            {
                btnAvisarme2.Text = "Avísame";
            }
            btnAvisarme2.Text = Idiomas.cambiarIdiomaBotonAvisame(btnAvisarme2.Text);

        }

        private void btnAvisarme3_Click(object sender, EventArgs e)
        {
            if (btnAvisarme3.Text.Equals("Notify") || btnAvisarme3.Text.Equals("Avísame"))
            {
                btnAvisarme3.Text = "No me avises";
            }
            else
            {
                btnAvisarme3.Text = "Avísame";
            }
            btnAvisarme3.Text = Idiomas.cambiarIdiomaBotonAvisame(btnAvisarme3.Text);

        }

        private void btnAvisarme4_Click(object sender, EventArgs e)
        {
            if (btnAvisarme4.Text.Equals("Notify") || btnAvisarme4.Text.Equals("Avísame"))
            {
                btnAvisarme4.Text = "No me avises";
            }
            else
            {
                btnAvisarme4.Text = "Avísame";
            }
            btnAvisarme4.Text = Idiomas.cambiarIdiomaBotonAvisame(btnAvisarme4.Text);


        }
    }
}
