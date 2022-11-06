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
        private void cerrar()
        {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }
        Equipos equipos = new Equipos();
        Deportes deportes = new Deportes();
        Jugador jugador = new Jugador();

        private void GestionarDeportes_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            switch (Logica.nombresDeportes(lista))
            {
                case 0:
                    cmboxDeporteEquipo.Items.Clear();
                    cmboxDeporteEquipo.Text = null;
                    foreach (string nombre in lista)
                    {
                        cmboxDeporteEquipo.Items.Add(nombre);
                    }
                    cmboxDeporteEquipo.Text = lista[0];

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes cargados");
                    break;
            }
        }

        private void btnCerrarI_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();

        }
        private void refrescarDeportesEquipo()
        {
            List<string> lista2 = new List<string>();
            switch (Logica.nombresDeportes(lista2))
            {
                case 0:
                    cmboxDeporteEquipo.Items.Clear();
                    cmboxDeporteEquipo.Text = null;
                    foreach (string nombre in lista2)
                    {
                        cmboxDeporteEquipo.Items.Add(nombre);
                    }
                    cmboxDeporteEquipo.Text = lista2[0];

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes cargados");
                    break;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            List<string> lista2 = new List<string>();
            switch (Logica.nombresDeportes(lista2))
            {
                case 0:
                    cmboxDeporteEquipo.Items.Clear();
                    cmboxDeporteEquipo.Text = null;
                    foreach (string nombre in lista2)
                    {
                        cmboxDeporteEquipo.Items.Add(nombre);
                    }
                    cmboxDeporteEquipo.Text = lista2[0];

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes cargados");
                    break;
            }

            List<string> lista = new List<string>();
            switch (Logica.cargarNombreEquipos(lista))
            {
                case 0:
                    cmboxEquipos.Items.Clear();
                    foreach (string nombre in lista)
                    {
                        cmboxEquipos.Items.Add(nombre);
                    }
                    cmboxEquipos.Text = lista[0];

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
            try
            {
                refrescarDeportesEquipo();
                deportes.nombre = null;
                equipos.nombre = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                equipos.categoria = cmboxEquipos.Text.Substring((cmboxEquipos.Text.IndexOf("/") + 1), (cmboxEquipos.Text.Length - (cmboxEquipos.Text.IndexOf("/") + 1)));
                bool bandera = true;
                int random = 0;
                Random r = new Random();
                List<int> cantidad = new List<int>();
                switch (Logica.cargarDatosEquipo(equipos, deportes))
                {
                    case 0:
                        btnAplicar.Enabled = true;
                        paneDatos.Enabled = true;
                        btnEliminarEquipo.Enabled = true;
                        paneIDEquipos.Enabled = false;
                        txtNombreEquipo.Text = equipos.nombre;
                        txtCategoria.Text = equipos.categoria;
                        txtLogo.Text = equipos.logo;
                        txtIDequipo.Text = Convert.ToString(equipos.id);
                        txtPais.Text = equipos.pais;
                        cmboxDeporteEquipo.Enabled = false;
                        List<string> lista = new List<string>();
                        switch (Logica.cargarNombreJugadores(lista))
                        {
                            case 0:
                                cmboxNombreJugador.Items.Clear();
                                foreach (string nombre in lista)
                                {
                                    cmboxNombreJugador.Items.Add(nombre);
                                }
                                cmboxNombreJugador.Text = lista[0];

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
                                foreach (string nombre in lista)
                                {
                                    cmboxListaJugadores.Items.Add(nombre);
                                }
                                cmboxListaJugadores.Text = lista[0];

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
                        if (deportes.nombre.Equals("NO"))
                        {
                            MessageBox.Show("Este equipo no practica deporte, por defecto se le asignó futbol. \nEscoja el que corresponda y presione Aceptar");
                            cmboxDeporteEquipo.Text = "Futbol";
                        }
                        else
                        {
                            cmboxDeporteEquipo.Text = deportes.nombre;
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
                            btnCrearEquipos.Enabled = true;
                            paneDatos.Enabled = true;
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
                            txtNombreEquipo.Text = cmboxEquipos.Text.Substring(0, cmboxEquipos.Text.IndexOf("/"));
                            txtIDequipo.Enabled = false;
                            txtNombreEquipo.Enabled = false;
                            paneAnadirJugadores.Enabled = false;
                            cmboxDeporteEquipo.Enabled = true;
                            this.refrescarDeportes2();
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
                            cmboxNombreJugador.Items.Clear();
                            cmboxListaJugadores.Items.Clear();
                        }

                        break;
                    case 6:
                        MessageBox.Show("El equipo no tiene deporte asignado y no se le puede asignar al por defecto. \nVerifique que el deporte 'Futbol' existe");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Error, el formato debe ser: <nombreEquipo>/<categoria>");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int random = 0; bool bandera = true;
            Random r = new Random();
            List<string> lista = new List<string>();
            deportes.nombre = cmboxIDdeporte.Text;
            switch (Logica.DatosDeporte(lista, deportes))
            {
                case 0:
                    paneModificar.Enabled = true;
                    txtMNombre.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    txtIDDeporte.Text = deportes.id.ToString();
                    txtMCategoria.Text = deportes.categoria;
                    txtMNombre.Text = deportes.nombre;
                    cmboxEquiposDeporte.Items.Clear();
                    cmboxEquiposDeporte.Text = null;
                    foreach (string nombre in lista)
                    {
                        cmboxEquiposDeporte.Items.Add(nombre);
                    }
                    cmboxEquiposDeporte.Text = lista[0];
                    paneBuscar.Enabled = false;

                    break;
                case 1:
                    MessageBox.Show("Error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
                case 3:
                    DialogResult crearDeporte;
                    crearDeporte = MessageBox.Show("El deporte que busca no existe, desea crearlo? ", "Crear deporte", MessageBoxButtons.YesNo);
                    if (crearDeporte == DialogResult.Yes)
                    {
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        while (bandera == true)
                        {
                            random = r.Next();
                            switch (Logica.BuscarIDdeporte(random))
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
                        paneBuscar.Enabled = false;
                        paneModificar.Enabled = true;
                        btnCrearDeporte.Enabled = true;
                        txtIDDeporte.Text = random.ToString();
                        txtMNombre.Enabled = true;
                        txtMNombre.Text = cmboxIDdeporte.Text;
                    }
                    else
                    {

                        txtIDDeporte.Text = null;
                        txtMCategoria.Text = null;
                        txtMNombre.Text = null;
                        cmboxEquiposDeporte.Items.Clear();
                        cmboxEquiposDeporte.Text = null;

                    }
                    break;
                case 4:
                    MessageBox.Show("A este deporte actualmente no se dedica ningún equipo");
                    txtIDDeporte.Text = deportes.id.ToString();
                    txtMCategoria.Text = deportes.categoria;
                    txtMNombre.Text = deportes.nombre;
                    cmboxEquiposDeporte.Items.Clear();
                    cmboxEquiposDeporte.Text = null;
                    paneBuscar.Enabled = false;
                    paneModificar.Enabled = true;
                    txtMNombre.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
            }

        }

        private void btnRefrescarJugadores_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreJugadores(lista))
            {
                case 0:
                    cmboxNombreJugador.Items.Clear();
                    foreach (string nombre in lista)
                    {
                        cmboxNombreJugador.Items.Add(nombre);
                    }
                    cmboxNombreJugador.Text = lista[0];

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
                    foreach (string nombre in lista)
                    {
                        cmboxListaJugadores.Items.Add(nombre);
                    }
                    cmboxListaJugadores.Text = lista[0];
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
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            List<int> cantidad = new List<int>();

            jugador.nombre = cmboxNombreJugador.Text.Substring(0, cmboxNombreJugador.Text.IndexOf(" "));
            jugador.apelido = cmboxNombreJugador.Text.Substring((cmboxNombreJugador.Text.IndexOf(" ") + 1), (cmboxNombreJugador.Text.Length - (cmboxNombreJugador.Text.IndexOf(" ") + 1)));
            switch (Logica.averiguarIDjugador(jugador.nombre, jugador.apelido, jugador))
            {
                case 0:
                    switch (Logica.añadirJugadoraEquipo(equipos.id, jugador.id, equipos.idDeporte))
                    {
                        case 0:
                            MessageBox.Show("Jugador agregado a equipo correctamente");
                            List<string> lista = new List<string>();
                            switch (Logica.cargarNombreJugadores(lista))
                            {
                                case 0:
                                    cmboxNombreJugador.Items.Clear();
                                    foreach (string nombre in lista)
                                    {
                                        cmboxNombreJugador.Items.Add(nombre);
                                    }
                                    cmboxNombreJugador.Text = lista[0];

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
                                    foreach (string nombre in lista)
                                    {
                                        cmboxListaJugadores.Items.Add(nombre);
                                    }
                                    cmboxListaJugadores.Text = lista[0];

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

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            List<int> cantidad = new List<int>();
            jugador.nombre = cmboxListaJugadores.Text.Substring(0, cmboxListaJugadores.Text.IndexOf(" "));
            jugador.apelido = cmboxListaJugadores.Text.Substring((cmboxListaJugadores.Text.IndexOf(" ") + 1), (cmboxListaJugadores.Text.Length - (cmboxListaJugadores.Text.IndexOf(" ") + 1)));
            switch (Logica.averiguarIDjugador(jugador.nombre, jugador.apelido, jugador))
            {
                case 0:
                    switch (Logica.quitarJugadorEquipo(equipos.id, jugador.id, equipos.idDeporte))
                    {
                        case 0:
                            MessageBox.Show("Jugador desvinculado al equipo correctamente");
                            List<string> lista = new List<string>();
                            switch (Logica.cargarJugadoresParticipaEquipo(lista, equipos.id))
                            {
                                case 0:
                                    cmboxListaJugadores.Items.Clear();
                                    foreach (string nombre in lista)
                                    {
                                        cmboxListaJugadores.Items.Add(nombre);
                                    }
                                    cmboxListaJugadores.Text = lista[0];

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
    
        

        private void btnCrearEquipos_Click(object sender, EventArgs e)
        {
            equipos.id = Convert.ToInt32(txtIDequipo.Text);
            equipos.nombre = txtNombreEquipo.Text;
            equipos.logo = txtLogo.Text;
            equipos.pais = txtPais.Text;
            equipos.categoria = txtCategoria.Text;
            
            string deporteDedica = cmboxDeporteEquipo.Text;
            switch (Logica.crearEquipo(equipos, deporteDedica)) {
                case 0:
                    MessageBox.Show("Equipo creado exitosamente");
                    txtIDequipo.Enabled = true;
                    btnCrearEquipos.Enabled = false;
                    paneDatos.Enabled = false;
                    cmboxDeporteEquipo.Enabled = false;
                    paneAnadirJugadores.Enabled = true;
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
                    cmboxNombreJugador.Items.Clear();
                    cmboxListaJugadores.Items.Clear();
                    List<string> lista2 = new List<string>();
                    switch (Logica.nombresDeportes(lista2))
                    {
                        case 0:
                            cmboxDeporteEquipo.Items.Clear();
                            cmboxDeporteEquipo.Text = null;
                            foreach (string nombre in lista2)
                            {
                                cmboxDeporteEquipo.Items.Add(nombre);
                            }
                            cmboxDeporteEquipo.Text = lista2[0];

                            break;
                        case 1:
                            MessageBox.Show("Ocurrió un error de red");
                            break;
                        case 2:
                            MessageBox.Show("Ocurrió un error inesperado");
                            break;
                        case 3:
                            MessageBox.Show("No existen deportes cargados");
                            break;
                    }
                    List<string> lista = new List<string>();
                    switch (Logica.cargarNombreEquipos(lista))
                    {
                        case 0:
                            cmboxEquipos.Items.Clear();
                            foreach (string nombre in lista)
                            {
                                cmboxEquipos.Items.Add(nombre);
                            }
                            cmboxEquipos.Text = lista[0];

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
            cmboxDeporteEquipo.Enabled = false;
            txtNombreEquipo.Enabled = true;
            txtIDequipo.Enabled = true;
            txtIDequipo.Text = null;
            txtCantidadJugadores.Text = null;
            txtLogo.Text = null;
            txtCategoria.Text = null;
            txtPais.Text = null;
            txtNombreEquipo.Text = null;
            cmboxNombreJugador.Items.Clear();
            cmboxListaJugadores.Items.Clear();
            paneAnadirJugadores.Enabled = true;
            paneDatos.Enabled = false;
            btnAplicar.Enabled = false;
            btnEliminarEquipo.Enabled = false;
            cmboxDeporteEquipo.Enabled = true;

        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {

            try
            {
                jugador.nombre = cmboxIDjugador.Text.Substring(0, cmboxIDjugador.Text.IndexOf(" "));
                jugador.apelido = cmboxIDjugador.Text.Substring((cmboxIDjugador.Text.IndexOf(" ") + 1), (cmboxIDjugador.Text.Length - (cmboxIDjugador.Text.IndexOf(" ") + 1)));
                switch (Logica.buscarDatosJugador(jugador))
                {
                    case 0:
                        btnAplicarCambios.Enabled = true;
                        txtIDjugadores.Text = jugador.id.ToString();
                        txtNombreJugadores.Text = jugador.nombre;
                        txtApellidoJugadores.Text = jugador.apelido;
                        txtSexoJugadores.Text = jugador.sexo.ToString();
                        txtEdadJugadores.Text = jugador.edad.ToString();
                        txtPaisJugadores.Text = jugador.paisNacimiento;
                        paneDatosJugador.Enabled = true;
                        paneIDjugadores.Enabled = false;
                        btnBorrarJugador.Enabled = true;

                        break;
                    case 1:
                        MessageBox.Show("Ocurrió un error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error inesperado");
                        break;
                    case 3:
                        DialogResult crearJugador = MessageBox.Show("El jugador no existe, desea crearlo? ", "Creación de jugador", MessageBoxButtons.YesNo);
                        if (crearJugador == DialogResult.Yes)
                        {
                            paneIDjugadores.Enabled = false;
                            btnAplicarCambios.Enabled = false;
                            bool bandera = true;
                            int random = 0;
                            Random r = new Random();
                            while (bandera == true)
                            {
                                random = r.Next();
                                switch (Logica.buscarIdJugador(random))
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
                            txtIDjugadores.Text = random.ToString();
                            txtIDjugadores.Enabled = false;
                            txtNombreJugadores.Text = cmboxIDjugador.Text.Substring(0, cmboxIDjugador.Text.IndexOf(" "));
                            txtApellidoJugadores.Text = cmboxIDjugador.Text.Substring((cmboxIDjugador.Text.IndexOf(" ") + 1), (cmboxIDjugador.Text.Length - (cmboxIDjugador.Text.IndexOf(" ") + 1)));
                            btnCrearJugador.Enabled = true;
                        }
                        else
                        {

                        }
                        break;
                }
            }
            catch {
                MessageBox.Show("Debe escribir el nombre y apellido del jugador (separados por un espacio)");
            }

        }
        private void cargarTODOSJugadores() {
            List<string> lista = new List<string>();
            switch (Logica.cargarNombreJugadores(lista))
            {
                case 0:
                    cmboxIDjugador.Items.Clear();
                    foreach (string nombre in lista)
                    {
                        cmboxIDjugador.Items.Add(nombre);
                    }
                    cmboxIDjugador.Text = lista[0];

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
        }
        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            this.cargarTODOSJugadores();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                jugador.apelido = txtApellidoJugadores.Text;
                jugador.nombre = txtNombreJugadores.Text;
                jugador.edad = Convert.ToInt32(txtEdadJugadores.Text);
                jugador.id = Convert.ToInt32(txtIDjugadores.Text);
                jugador.paisNacimiento = txtPaisJugadores.Text;
                try
                {
                    jugador.sexo = Convert.ToChar(txtSexoJugadores.Text);
                    switch (Logica.actualizarJugador(jugador))
                    {
                        case 0:
                            btnAplicarCambios.Enabled = false;
                            MessageBox.Show("Jugador actualizado correctamente");
                            txtIDjugadores.Text = null;
                            txtNombreJugadores.Text = null;
                            txtApellidoJugadores.Text = null;
                            txtSexoJugadores.Text = null;
                            txtEdadJugadores.Text = null;
                            txtPaisJugadores.Text = null;
                            this.cargarTODOSJugadores();
                            paneDatosJugador.Enabled = false;
                            paneIDjugadores.Enabled = true;
                            btnBorrarJugador.Enabled = false;

                            break;
                        case 1:
                            MessageBox.Show("Error de conexión");
                            break;
                        case 2:
                            MessageBox.Show("Error inesperado");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Sexo debe ser M o F ");
                    txtSexoJugadores.Text = null;
                }
            }
            catch {
                MessageBox.Show("Id no es correcto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                jugador.apelido = txtApellidoJugadores.Text;
                jugador.nombre = txtNombreJugadores.Text;
                jugador.edad = Convert.ToInt32(txtEdadJugadores.Text);
                jugador.id = Convert.ToInt32(txtIDjugadores.Text);
                jugador.paisNacimiento = txtPaisJugadores.Text;
                try
                {
                    jugador.sexo = Convert.ToChar(txtSexoJugadores.Text);
                    switch (Logica.crearJugador(jugador))
                    {
                        case 0:
                            MessageBox.Show("Jugador creado correctamente");
                            txtIDjugadores.Text = null;
                            txtNombreJugadores.Text = null;
                            txtApellidoJugadores.Text = null;
                            txtSexoJugadores.Text = null;
                            txtEdadJugadores.Text = null;
                            txtPaisJugadores.Text = null;
                            this.cargarTODOSJugadores();
                            paneDatosJugador.Enabled = false;
                            btnAplicarCambios.Enabled = true;
                            paneIDjugadores.Enabled = true;
                            btnCrearJugador.Enabled = false;


                            break;
                        case 1:
                            MessageBox.Show("Error de conexión");
                            break;
                        case 2:
                            MessageBox.Show("Error inesperado");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Sexo debe ser M o F ");
                    txtSexoJugadores.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("La edad debe ser numérica");
            }

        }

        private void btnCancelarJugador_Click(object sender, EventArgs e)
        {
            btnAplicarCambios.Enabled = false;
            paneDatosJugador.Enabled = false;
            txtIDjugadores.Text = null;
            txtNombreJugadores.Text = null;
            txtApellidoJugadores.Text = null;
            txtSexoJugadores.Text = null;
            txtEdadJugadores.Text = null;
            txtPaisJugadores.Text = null;
            this.cargarTODOSJugadores();
            btnAplicarCambios.Enabled = true;
            btnBorrarJugador.Enabled = false;
            btnCrearJugador.Enabled = false;
            paneIDjugadores.Enabled = true;
        }

        private void btnBorrarJugador_Click(object sender, EventArgs e)
        {
            DialogResult seguro = MessageBox.Show("Está seguro?", "Eliminar Jugador", MessageBoxButtons.YesNo);
            if (seguro == DialogResult.Yes)
            {
                jugador.id = Convert.ToInt32(txtIDjugadores.Text);
                switch (Logica.BorrarJugador(jugador.id))
                {
                    case 0:
                        btnBorrarJugador.Enabled = false;
                        txtIDjugadores.Text = null;
                        txtNombreJugadores.Text = null;
                        txtApellidoJugadores.Text = null;
                        txtSexoJugadores.Text = null;
                        txtEdadJugadores.Text = null;
                        txtPaisJugadores.Text = null;
                        this.cargarTODOSJugadores();
                        paneDatosJugador.Enabled = false;
                        btnAplicarCambios.Enabled = true;
                        paneIDjugadores.Enabled = true;
                        MessageBox.Show("Jugador borrado exitosamente");
                        break;
                    case 1:
                        MessageBox.Show("Error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado. El jugador figura en algun torneo");
                        break;
                }
            }
            else {
                MessageBox.Show("Se canceló la eliminación");
                btnBorrarJugador.Enabled = false;
                txtIDjugadores.Text = null;
                txtNombreJugadores.Text = null;
                txtApellidoJugadores.Text = null;
                txtSexoJugadores.Text = null;
                txtEdadJugadores.Text = null;
                txtPaisJugadores.Text = null;
                this.cargarTODOSJugadores();
                btnAplicarCambios.Enabled = true;
                paneIDjugadores.Enabled = true;
            }
            
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            deportes.nombre = cmboxDeporteEquipo.Text;
            int id;
            if (int.TryParse(txtIDequipo.Text, out id))
            {
                equipos.id = id;
                equipos.nombre = txtNombreEquipo.Text;
                equipos.logo = txtLogo.Text;
                equipos.pais = txtPais.Text;
                equipos.categoria = txtCategoria.Text;
                switch (Logica.actualizarEquipo(equipos, deportes.nombre)) {
                    case 0:
                        cmboxDeporteEquipo.Text = deportes.nombre;
                        MessageBox.Show("Equipo actualizado correctamente");
                        paneIDEquipos.Enabled = true;
                        paneAnadirJugadores.Enabled = true;
                        txtNombreEquipo.Enabled = true;
                        txtIDequipo.Text = null;
                        txtCantidadJugadores.Text = null;
                        txtLogo.Text = null;
                        txtCategoria.Text = null;
                        txtPais.Text = null;
                        txtNombreEquipo.Text = null;
                        btnEliminarEquipo.Enabled = false;
                        cmboxNombreJugador.Items.Clear();
                        cmboxListaJugadores.Items.Clear();
                        paneAnadirJugadores.Enabled = true;
                        paneDatos.Enabled = false;
                        btnAplicar.Enabled = false;
                        List<string> lista2 = new List<string>();
                        switch (Logica.nombresDeportes(lista2))
                        {
                            case 0:
                                cmboxDeporteEquipo.Items.Clear();
                                cmboxDeporteEquipo.Text = null;
                                foreach (string nombre in lista2)
                                {
                                    cmboxDeporteEquipo.Items.Add(nombre);
                                }
                                cmboxDeporteEquipo.Text = lista2[0];

                                break;
                            case 1:
                                MessageBox.Show("Ocurrió un error de red");
                                break;
                            case 2:
                                MessageBox.Show("Ocurrió un error inesperado");
                                break;
                            case 3:
                                MessageBox.Show("No existen deportes cargados");
                                break;
                        }

                        List<string> lista = new List<string>();
                        switch (Logica.cargarNombreEquipos(lista))
                        {
                            case 0:
                                cmboxEquipos.Items.Clear();
                                foreach (string nombre in lista)
                                {
                                    cmboxEquipos.Items.Add(nombre);
                                }
                                cmboxEquipos.Text = lista[0];

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
                        break;
                    case 1:
                        MessageBox.Show("Error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado");
                        break;
                    case 5:
                        MessageBox.Show("Error, no se pudo asignar al deporte");
                        break;
                }
            }
            else {
                MessageBox.Show("Ocurrió un error obteniendo el ID");
            }
            

        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult seguro = MessageBox.Show("Está seguro?", "Eliminar Jugador", MessageBoxButtons.YesNo);
            if (seguro == DialogResult.Yes)
            {
                equipos.id = Convert.ToInt32(txtIDequipo.Text);
                switch (Logica.BorrarEquipo(equipos.id, equipos.idDeporte))
                {
                    case 0:
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
                        paneAnadirJugadores.Enabled = true;
                        paneDatos.Enabled = false;
                        btnAplicar.Enabled = false;
                        btnEliminarEquipo.Enabled = false;
                        List<string> lista2 = new List<string>();
                        switch (Logica.nombresDeportes(lista2))
                        {
                            case 0:
                                cmboxDeporteEquipo.Items.Clear();
                                cmboxDeporteEquipo.Text = null;
                                foreach (string nombre in lista2)
                                {
                                    cmboxDeporteEquipo.Items.Add(nombre);
                                }
                                cmboxDeporteEquipo.Text = lista2[0];

                                break;
                            case 1:
                                MessageBox.Show("Ocurrió un error de red");
                                break;
                            case 2:
                                MessageBox.Show("Ocurrió un error inesperado");
                                break;
                            case 3:
                                MessageBox.Show("No existen deportes cargados");
                                break;
                        }

                        List<string> lista = new List<string>();
                        switch (Logica.cargarNombreEquipos(lista))
                        {
                            case 0:
                                cmboxEquipos.Items.Clear();
                                foreach (string nombre in lista)
                                {
                                    cmboxEquipos.Items.Add(nombre);
                                }
                                cmboxEquipos.Text = lista[0];

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
                        MessageBox.Show("Equipo borrado exitosamente");
                        break;
                    case 1:
                        MessageBox.Show("Error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Error inesperado. El equipo pertenece a algun encuentro o tiene jugadores");
                        break;
                }
            }
        }

        private void refrescarDeportes() {
            List<string> lista = new List<string>();
            switch (Logica.nombresDeportes(lista))
            {
                case 0:
                    cmboxIDdeporte.Items.Clear();
                    cmboxEquiposDeporte.Text = null;
                    foreach (string nombre in lista)
                    {
                        cmboxIDdeporte.Items.Add(nombre);
                    }
                    cmboxIDdeporte.Text = lista[0];

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes    -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          cargados");
                    break;
            }
        }
        private void refrescarDeportes2()
        {
            List<string> lista = new List<string>();
            switch (Logica.nombresDeportes(lista))
            {
                case 0:
                    cmboxDeporteEquipo.Items.Clear();
                    cmboxDeporteEquipo.Text = null;
                    foreach (string nombre in lista)
                    {
                        cmboxDeporteEquipo.Items.Add(nombre);
                    }
                    cmboxDeporteEquipo.Text = lista[0];

                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de red");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
                case 3:
                    MessageBox.Show("No existen deportes    -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          cargados");
                    break;
            }
        }

        private void btnRefrescarDeportes_Click(object sender, EventArgs e)
        {
            refrescarDeportes();
        }

        private void paneModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearDeporte_Click(object sender, EventArgs e)
        {
            deportes.id = Convert.ToInt32(txtIDDeporte.Text);
            deportes.nombre = txtMNombre.Text;
            deportes.categoria = txtMCategoria.Text;
            switch (Logica.crearDeporte(deportes)) {
                case 0:
                    MessageBox.Show("Deporte creado exitosamente");
                    txtIDDeporte.Text = null;
                    txtMCategoria.Text = null;
                    txtMNombre.Text = null;
                    txtMNombre.Enabled = false;
                    btnEliminar.Enabled = false;
                    cmboxEquiposDeporte.Items.Clear();
                    txtMNombre.Enabled = false;
                    paneBuscar.Enabled = true;
                    cmboxEquiposDeporte.Text = null;
                    refrescarDeportes();
                    btnModificar.Enabled = false;
                    paneModificar.Enabled = false;
                    btnCrearDeporte.Enabled = false;
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado, verifique que el nombre del deporte sea correcto");
                    break;

            }
            }

        private void btnMcancelar_Click(object sender, EventArgs e)
        {
            paneModificar.Enabled = false;
            txtMNombre.Enabled = false;
            paneBuscar.Enabled = true;
            txtIDDeporte.Text = null;
            txtMCategoria.Text = null;
            txtMNombre.Text = null;
            cmboxEquiposDeporte.Items.Clear();
            cmboxEquiposDeporte.Text = null;
            btnCrearDeporte.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDeporte = Convert.ToInt32(txtIDDeporte.Text);
            switch (Logica.BorrarDeporte(idDeporte)) {
                case 0:
                    paneModificar.Enabled = false;
                    paneBuscar.Enabled = true;
                    txtIDDeporte.Text = null;
                    txtMCategoria.Text = null;
                    txtMNombre.Enabled = false;
                    txtMNombre.Text = null;
                    cmboxEquiposDeporte.Items.Clear();
                    cmboxEquiposDeporte.Text = null;
                    refrescarDeportes();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    MessageBox.Show("Equipo borrado exitosamente");
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado. Las causas pueden ser: \n    Al deporte lo practica algun equipo");
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            deportes.id = Convert.ToInt32(txtIDDeporte.Text);
            deportes.categoria = txtMCategoria.Text;
            deportes.nombre = txtMNombre.Text;

            switch (Logica.actualizarDeporte(deportes)) {
                case 0:
                    MessageBox.Show("Deporte actualizado correctamente");
                    txtMNombre.Enabled = false;
                    break;
                case 1:
                    MessageBox.Show("Error de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado, revise la categoria");
                    break;
                case 3:
                    MessageBox.Show("Error inesperado.\nEl nombre ya esta en uso o posee mas de 50 caracteres");
                    txtMNombre.Text = cmboxIDdeporte.Text;
                    break;
            }
        }

        

        private void btnCerrarIII_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }
    }
}

