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
    public partial class EncuentrosTorneos : Form
    {
        public EncuentrosTorneos()
        {
            InitializeComponent();
        }
        EncuentrosColectivos encuentros = new EncuentrosColectivos();
        private void EncuentrosTorneos_Load(object sender, EventArgs e)
        {

        }
        public void filtrar()
        {
            try
            {
                string deporteTorneo = cmboxDeportes.Text;
                List<string> encuentros = new List<string>();
                switch (Logica.datosEncuentrosDisponibles(GestionarTorneos.torneosColectivos.idTorneo, encuentros, deporteTorneo))
                {
                    case 0:
                        cmboxEncuentros.Items.Clear();
                        cmboxEncuentros.Text = null;
                        foreach (string nombre in encuentros)
                        {
                            cmboxEncuentros.Items.Add(nombre);
                        }
                        cmboxEncuentros.Text = encuentros[0];
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado.\nRefresque la pagina e intente nuevamente");
                        break;
                    case 3:
                        MessageBox.Show("No se encontraron encuentros disponibles en el sistema");
                        break;
                }
            }
            catch {
                MessageBox.Show("No hay encuentros disponibles con este deporte");
            }
        }
        public void refrescarDatosEvento() {
            int id = 0;
            if (int.TryParse(cmboxEncuentros.Text.Substring(3, (cmboxEncuentros.Text.IndexOf(" ") - 3)), out id))
            {
                txtHoraFinaliza.Text = null;
                txtFechaComienzo.Text = null;
                cmboxEquiposDeEncuentros.Items.Clear();
                encuentros.idEncuentro = id;
                List<string> equiposEncuentro = new List<string>();
                switch (Logica.DatosEncuentrosColectivos(encuentros, equiposEncuentro))
                {
                    case 0:
                        btnAgregar.Enabled = true;
                        txtFechaComienzo.Text = encuentros.fechaComienzo.ToString();
                        txtHoraFinaliza.Text = encuentros.fechaFinaliza.ToString();
                        MessageBox.Show(encuentros.fechaComienzo.ToString());
                        cmboxEquiposDeEncuentros.Items.Clear();
                        foreach (string nombreEquipo in equiposEncuentro) {
                            cmboxEquiposDeEncuentros.Items.Add(nombreEquipo);
                        }
                        cmboxEquiposDeEncuentros.Text = equiposEncuentro[0];
                        break;
                    case 1:
                        MessageBox.Show("Error de red");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 5:
                        btnAgregar.Enabled = false;
                        MessageBox.Show("El encuentro no tiene equipos");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error obteniendo el ID");
            }
        }
            private void btnRefrescar_Click(object sender, EventArgs e)
        {
           
                List<string> lista = new List<string>();
                switch (Logica.nombresDeportes(lista))
                {
                    case 0:
                    cmboxDeportes.Items.Clear();
                        foreach (string nombre in lista)
                        {
                        cmboxDeportes.Items.Add(nombre);
                        }
                    cmboxDeportes.Text = lista[0];

                    break;
                    case 1:
                        MessageBox.Show("Ocurrió un error de red");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("No existen deportes en el sistema");
                    break;
                }
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.filtrar();
        }

        private void cmboxEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarDatosEvento();
        }

        private void btnVerCargados_Click(object sender, EventArgs e)
        {
            refrescarDatosEvento();

        }

        private void cmboxEquiposDeEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
