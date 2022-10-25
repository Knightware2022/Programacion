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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.frmPrincipal.Enabled = true;
        }
        public void refrescarEquiposCargados()
        {
            List<string> nombresEquipos = new List<string>();
            switch (Logica.EquiposEncuentrosColectivos(GestionarEventos.encuentrosColectivos.idEncuentro, nombresEquipos))
            {
                case 0:
                    cmboxEquipo.Items.Clear();
                    cmboxEquipo.Text = null;
                    cmboxEquipo.Text = nombresEquipos[0];
                    foreach (string nombre in nombresEquipos)
                    {
                        cmboxEquipo.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado.\nRefresque la pagina e intente nuevamente");
                    break;
                case 3:
                    MessageBox.Show("El encuentro no tiene equipos cargados");
                    break;
            }
        }
        private void refrescarJugadorEquipo()
        {
            string nombreEquipo = cmboxEquipo.Text.Substring(0, cmboxEquipo.Text.IndexOf("/"));
            string categoriaEquipo = cmboxEquipo.Text.Substring((cmboxEquipo.Text.IndexOf("/") + 1), (cmboxEquipo.Text.Length - (cmboxEquipo.Text.IndexOf("/") + 1)));
            List<string> nombresJugadores = new List<string>();
            switch (Logica.mostrarJugadoresDeEquipo(nombreEquipo, categoriaEquipo, GestionarEventos.encuentrosColectivos.idEncuentro, nombresJugadores))
            {
                case 0:
                    cmboxJugador.Items.Clear();
                    cmboxJugador.Text = null;
                    cmboxJugador.Text = nombresJugadores[0];
                    foreach (string nombre in nombresJugadores)
                    {
                        cmboxJugador.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado.\nRefresque la pagina e intente nuevamente");
                    break;
                case 3:
                    MessageBox.Show("No se encontraron jugadores");
                    break;
            }
        }
        private void refrescarIncidencias()
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
            
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarJugadorEquipo();
            this.refrescarIncidencias();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = cmboxJugador.Text.Substring(0, cmboxJugador.Text.IndexOf(" "));
            string apelido = cmboxJugador.Text.Substring((cmboxJugador.Text.IndexOf(" ") + 1), (cmboxJugador.Text.Length - (cmboxJugador.Text.IndexOf(" ") + 1)));
            string ocurrencia = cmboxIncidencia.Text;
            int minuto;
            if (Int32.TryParse(txtMinuto.Text, out minuto))
            {
                bool bandera = true;
                Random r = new Random();
                int idRandom = 0;
                while (bandera == true)
                {
                    idRandom = r.Next();
                    switch (Logica.BuscarIDIncidencias(idRandom))
                    {
                        case 0:
                            break;
                        case 1:
                        case 2:
                            MessageBox.Show("Ocurrió un error, intente mas tarde");
                            break;
                        case 3:
                            bandera = false;
                            break;
                    }
                }
                switch (Logica.InsertarenNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, idRandom, minuto, nombre, apelido, ocurrencia))
                {
                    case 0:
                        MessageBox.Show("Se registro la incidencia exitosamente");
                        txtMinuto.Text = null;
                        break;
                    case 1:
                        MessageBox.Show("Error de red");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("Error insertando Hacen");
                        break;
                    case 4:
                        MessageBox.Show("Error insertando en Notifica");
                        break;
                }
            }
            else {
                MessageBox.Show("Minuto no valido, debe ser un entero");
            }
            
        }

        private void cmboxIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadorEquipo();
        }
    }
}
