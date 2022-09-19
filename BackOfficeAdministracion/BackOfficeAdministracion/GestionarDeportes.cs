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
        Equipos equipos = new Equipos();
        Jugador jugador = new Jugador();
        private void btnCerrarI_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreEquipos(lista)) {
                case 0:
                    cmboxEquipos.Items.Clear();
                    cmboxEquipos.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxEquipos.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen equipos cargados");
                    break;
            }
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            int random = 0;
            Random r = new Random();
            List<int> cantidad = new List<int>();
            equipos.nombre = cmboxEquipos.Text;
            switch (Logica.cargarDatosEquipo(equipos)) {
                case 0:
                    paneIDEquipos.Enabled = false;
                    cmboxDeporteEquipo.Text = "Deporte al que se dedica";
                    txtNombreEquipo.Text = equipos.nombre;
                    txtCategoria.Text = equipos.categoria;
                    txtLogo.Text = equipos.logo;
                    txtIDequipo.Text = Convert.ToString(equipos.id);
                    txtPais.Text = equipos.pais;
                    List<string> lista = new List<string>();
                    switch (Logica.cargarNombreJugadores(lista))
                    {
                        case 0:
                            cmboxNombreJugador.Items.Clear();
                            cmboxNombreJugador.Text = lista[0];
                            foreach (string nombre in lista)
                            {
                                cmboxNombreJugador.Items.Add(nombre);
                            }
                            break;
                        case 1:
                            MessageBox.Show("Ocurrió un error de red");
                            break;
                        case 2:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;
                        case 3:
                            MessageBox.Show("No existen jugadores cargados");
                            break;
                    }
                    lista.Clear();
                    switch (Logica.cargarJugadoresParticipaEquipo(lista, equipos.id))
                    {
                        case 0:
                            cmboxListaJugadores.Items.Clear();
                            cmboxListaJugadores.Text = lista[0];
                            foreach (string nombre in lista)
                            {
                                cmboxListaJugadores.Items.Add(nombre);
                            }
                            break;
                        case 1:
                            MessageBox.Show("Ocurrió un error de red");
                            break;
                        case 2:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;
                        case 3:
                            MessageBox.Show("Advertenica!" + Environment.NewLine + "Este equipo no presenta jugadores cargados");
                            cmboxListaJugadores.Text = null;

                            break;
                    }

                    switch (Logica.contarJugadoresdeEquipo(equipos.id, cantidad)) {
                        case 0:
                            txtCantidadJugadores.Text = Convert.ToString(cantidad[0]);
                            break;
                        case 1:
                            MessageBox.Show("Ocurrió un error de conexión");
                            break;
                        case 2:
                        case 3:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;

                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    DialogResult crearEquipo;
                    crearEquipo = MessageBox.Show("El equipo que busca no existe, desea crearlo? ", "Crear Equipo", MessageBoxButtons.YesNo);
                    if (crearEquipo == DialogResult.Yes)
                    {
                        paneIDEquipos.Enabled = false;
                        while (bandera == true)
                        {
                            random = r.Next();
                            switch (Logica.BuscarIDequipo(random))
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
                        txtIDequipo.Text = random.ToString();
                        txtNombreEquipo.Text = cmboxEquipos.Text;
                        txtIDequipo.Enabled = false;
                        txtNombreEquipo.Enabled = false;
                        paneAnadirJugadores.Enabled = false;
                    }
                    else
                    {
                        paneIDEquipos.Enabled = true;
                        paneAnadirJugadores.Enabled = true;
                        txtNombreEquipo.Enabled = true;
                        txtIDequipo.Enabled = true;
                        txtIDequipo.Text = null;
                        txtCantidadJugadores.Text = null;
                        txtLogo.Text = null;
                        txtCategoria.Text = null;
                        txtPais.Text = null;
                        txtNombreEquipo.Text = null;
                        cmboxDeporteEquipo.Items.Clear();
                        cmboxNombreJugador.Items.Clear();
                        cmboxListaJugadores.Items.Clear();
                    }

                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescarJugadores_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreJugadores(lista))
            {
                case 0:
                    cmboxNombreJugador.Items.Clear();
                    cmboxNombreJugador.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxNombreJugador.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen jugadores cargados");
                    break;
            }
            lista.Clear();
            switch (Logica.cargarJugadoresParticipaEquipo(lista, equipos.id))
            {
                case 0:
                    cmboxListaJugadores.Items.Clear();
                    cmboxListaJugadores.Text = lista[0];
                    foreach (string nombre in lista)
                    {
                        cmboxListaJugadores.Items.Add(nombre);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("Advertenica!" + Environment.NewLine+ "Este equipo no presenta jugadores cargados");
                    cmboxListaJugadores.Text = null;
                    break;
            }
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            List<int> cantidad = new List<int>();

            try
            {
                jugador.nombre = cmboxNombreJugador.Text.Substring(0, cmboxNombreJugador.Text.IndexOf(" "));
                jugador.apelido = cmboxNombreJugador.Text.Substring((cmboxNombreJugador.Text.IndexOf(" ") + 1), (cmboxNombreJugador.Text.Length - (cmboxNombreJugador.Text.IndexOf(" ") + 1)));
                switch (Logica.averiguarIDjugador(jugador.nombre, jugador.apelido, jugador))
                {
                    case 0:
                        switch (Logica.añadirJugadoraEquipo(equipos.id, jugador.id))
                        {
                            case 0:
                                MessageBox.Show("Jugador agregado a equipo correctamente");
                                List<string> lista = new List<string>();
                                switch (Logica.cargarNombreJugadores(lista))
                                {
                                    case 0:
                                        cmboxNombreJugador.Items.Clear();
                                        cmboxNombreJugador.Text = lista[0];
                                        foreach (string nombre in lista)
                                        {
                                            cmboxNombreJugador.Items.Add(nombre);
                                        }
                                        break;
                                    case 1:
                                        MessageBox.Show("Ocurrió un error de red");
                                        break;
                                    case 2:
                                        MessageBox.Show("Ocurrió un error inesperado");
                                        break;
                                    case 3:
                                        MessageBox.Show("No existen jugadores cargados");
                                        break;
                                }
                                lista.Clear();
                                switch (Logica.cargarJugadoresParticipaEquipo(lista, equipos.id))
                                {
                                    case 0:
                                        cmboxListaJugadores.Items.Clear();
                                        cmboxListaJugadores.Text = lista[0];
                                        foreach (string nombre in lista)
                                        {
                                            cmboxListaJugadores.Items.Add(nombre);
                                        }
                                        break;
                                    case 1:
                                        MessageBox.Show("Ocurrió un error de red");
                                        break;
                                    case 2:
                                        MessageBox.Show("Ocurrió un error inesperado");
                                        break;
                                    case 3:
                                        MessageBox.Show("No existen jugadores cargados a este equipo");
                                        break;
                                }

                                switch (Logica.contarJugadoresdeEquipo(equipos.id, cantidad))
                                {
                                    case 0:
                                        txtCantidadJugadores.Text = Convert.ToString(cantidad[0]);
                                        break;
                                    case 1:
                                        MessageBox.Show("Ocurrió un error de conexión");
                                        break;
                                    case 2:
                                    case 3:
                                        MessageBox.Show("Ocurrió un error inesperado");
                                        break;

                                }
                                break;
                            case 1:
                                MessageBox.Show("Ocurrió un error de conexión");
                                break;
                            case 2:
                                MessageBox.Show("Jugador ya participa en este u otro equipo");
                                break;
                        }
                        break;
                    case 1:
                        MessageBox.Show("Ocurrió un error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("El jugador no existe");
                        break;
                }
            }
            catch {
                MessageBox.Show("Ocurrió un error obteniendo los datos del jugador");
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> cantidad = new List<int>();
                jugador.nombre = cmboxListaJugadores.Text.Substring(0, cmboxListaJugadores.Text.IndexOf(" "));
                jugador.apelido = cmboxListaJugadores.Text.Substring((cmboxListaJugadores.Text.IndexOf(" ") + 1), (cmboxListaJugadores.Text.Length - (cmboxListaJugadores.Text.IndexOf(" ") + 1)));
                switch (Logica.averiguarIDjugador(jugador.nombre, jugador.apelido, jugador))
                {
                    case 0:
                        switch (Logica.quitarJugadorEquipo(equipos.id, jugador.id))
                        {
                            case 0:
                                MessageBox.Show("Jugador desvinculado al equipo correctamente");
                                List<string> lista = new List<string>();
                                switch (Logica.cargarJugadoresParticipaEquipo(lista, equipos.id))
                                {
                                    case 0:
                                        cmboxListaJugadores.Items.Clear();
                                        cmboxListaJugadores.Text = lista[0];
                                        foreach (string nombre in lista)
                                        {
                                            cmboxListaJugadores.Items.Add(nombre);
                                        }
                                        break;
                                    case 1:
                                        MessageBox.Show("Ocurrió un error de red");
                                        break;
                                    case 2:
                                        MessageBox.Show("Ocurrió un error inesperado");
                                        break;
                                    case 3:
                                        cmboxListaJugadores.Text = null;
                                        break;
                                }

                                switch (Logica.contarJugadoresdeEquipo(equipos.id, cantidad))
                                {
                                    case 0:
                                        cmboxListaJugadores.Text = null;
                                        txtCantidadJugadores.Text = Convert.ToString(cantidad[0]);
                                        break;
                                    case 1:
                                        MessageBox.Show("Ocurrió un error de conexión");
                                        break;
                                    case 2:
                                    case 3:
                                        MessageBox.Show("Ocurrió un error inesperado");
                                        break;

                                }
                                break;
                            case 1:
                                MessageBox.Show("Ocurrió un error de conexión");
                                break;
                            case 2:
                                MessageBox.Show("Ocurrió un error inesperado");
                                break;
                        }
                        break;
                    case 1:
                        MessageBox.Show("Ocurrió un error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error inesperado");
                        break;
                    case 3:
                        MessageBox.Show("El jugador no participa en dicho equipo");
                        break;
                }
            }
            catch {
                MessageBox.Show("Jugador no existe");
            }
        }

        private void btnCrearEquipos_Click(object sender, EventArgs e)
        {
            equipos.id = Convert.ToInt32(txtIDequipo.Text);
            equipos.nombre = txtNombreEquipo.Text;
            equipos.logo = txtLogo.Text;
            equipos.pais = txtPais.Text;
            equipos.categoria = txtCategoria.Text;
            switch (Logica.crearEquipo(equipos)) {
                case 0:
                    MessageBox.Show("Equipo creado exitosamente");
                    txtIDequipo.Enabled = true;
                    txtNombreEquipo.Enabled = true;
                    paneAnadirJugadores.Enabled = true;
                    paneIDEquipos.Enabled = true;
                    paneAnadirJugadores.Enabled = true;
                    txtNombreEquipo.Enabled = true;
                    txtIDequipo.Enabled = true;
                    txtIDequipo.Text = null;
                    txtCantidadJugadores.Text = null;
                    txtLogo.Text = null;
                    txtCategoria.Text = null;
                    txtPais.Text = null;
                    txtNombreEquipo.Text = null;
                    cmboxDeporteEquipo.Items.Clear();
                    cmboxNombreJugador.Items.Clear();
                    cmboxListaJugadores.Items.Clear();
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado, verifique los datos");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            paneIDEquipos.Enabled = true;
            paneAnadirJugadores.Enabled = true;
            txtNombreEquipo.Enabled = true;
            txtIDequipo.Enabled = true;
            txtIDequipo.Text = null;
            txtCantidadJugadores.Text = null;
            txtLogo.Text = null;
            txtCategoria.Text = null;
            txtPais.Text = null;
            txtNombreEquipo.Text = null;
            cmboxDeporteEquipo.Items.Clear();
            cmboxNombreJugador.Items.Clear();
            cmboxListaJugadores.Items.Clear();
        }
    }
}
