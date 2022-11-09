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
    public partial class TorneosProgramados : Form
    {
        public TorneosProgramados()
        {
            InitializeComponent();
        }
        private void refrescarTorneos()
        {
            List<string> torneos = new List<string>();
            switch (ApiResultados.TorneosProgramados(torneos))
            {
                case 0:
                    cmboxTorneos.Items.Clear();
                    foreach (string nombre in torneos)
                    {
                        cmboxTorneos.Items.Add(nombre);
                    }
                    cmboxTorneos.Text = torneos[0];
                    break;
                case 3:
                    MessageBox.Show("No existen deportes programados");
                    break;
                default:
                    MessageBox.Show("Error de conexion");
                    break;
            }
        }
        private void refrescarEventos()
        {
            List<string> eventos = new List<string>();
            int id;
            if (int.TryParse(cmboxTorneos.Text.Substring(0, cmboxTorneos.Text.IndexOf(" ")), out id))
            {
                switch (ApiResultados.EventosDeTorneo(eventos, id))
                {
                    case 0:
                        cmboxNombreEvento.Items.Clear();
                        foreach (string nombre in eventos)
                        {
                            cmboxNombreEvento.Items.Add(nombre);
                        }
                        cmboxNombreEvento.Text = eventos[0];
                        break;
                    case 3:
                        MessageBox.Show("No existen eventos programados para este torneo");
                        break;
                    default:
                        MessageBox.Show("Error de conexion");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error obteniendo id");
            }
        }
        private void TorneosProgramados_Load(object sender, EventArgs e)
        {
            refrescarTorneos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarTorneos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.refrescarEventos();
        }
    }
}
