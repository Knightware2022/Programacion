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
    public partial class IncidenciasIndividuales : Form
    {
        public IncidenciasIndividuales()
        {
            InitializeComponent();
        }
        public void refrescarIncidencias()
        {
            {
                List<string> incidencias = new List<string>();
                switch (Logica.mostrarNombresIncidencias(incidencias))
                {
                    case 0:
                        cmboxIncidencia.Items.Clear();
                        cmboxIncidencia.Text = null;
                        cmboxIncidencia.Text = incidencias[0];
                        foreach (string nombre in incidencias)
                        {
                            cmboxIncidencia.Items.Add(nombre);
                        }
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado.\nRefresque la pagina e intente nuevamente");
                        break;
                    case 3:
                        MessageBox.Show("No se encontraron Ocurrencias en el sistema");
                        break;
                }
            }
        }
        public void refrescarParticipantesEncuentro()
        {
            List<string> lista = new List<string>();
            switch (Logica.participantesEncuentrosIndividuales(GestionarEventos.encuentrosIndividuales.idEncuentro, lista))
            {
                case 0:
                    cmboxJugador.Items.Clear();
                    cmboxJugador.Text = null;
                    cmboxJugador.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxJugador.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen participantes en el encuentro");
                    break;
            }
        }

        private void IncidenciasIndividuales_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.frmPrincipal.Enabled = true;

        }

        private void paneIncidencias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarIncidencias();
            this.refrescarParticipantesEncuentro();
        }
    }
}
