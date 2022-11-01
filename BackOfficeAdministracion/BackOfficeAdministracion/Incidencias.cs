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
            this.rbPuntos.Checked = true;
            this.mostrar_OcultarPanes();
            this.refrescarEquiposCargados();
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
                    foreach (string nombre in nombresEquipos)
                    {
                        cmboxEquipo.Items.Add(nombre);
                    }
                    cmboxEquipo.Text = nombresEquipos[0];

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
        public void refrescarJugadorEquipo()
        {
            string nombreEquipo = cmboxEquipo.Text.Substring(0, cmboxEquipo.Text.IndexOf("/"));
            string categoriaEquipo = cmboxEquipo.Text.Substring((cmboxEquipo.Text.IndexOf("/") + 1), (cmboxEquipo.Text.Length - (cmboxEquipo.Text.IndexOf("/") + 1)));
            List<string> nombresJugadores = new List<string>();
            switch (Logica.mostrarJugadoresDeEquipo(nombreEquipo, categoriaEquipo, GestionarEventos.encuentrosColectivos.idEncuentro, nombresJugadores))
            {
                case 0:
                    cmboxJugador.Items.Clear();
                    foreach (string nombre in nombresJugadores)
                    {
                        cmboxJugador.Items.Add(nombre);
                    }
                    cmboxJugador.Text = nombresJugadores[0];

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
        public void refrescarIncidencias()
        {
            {
                List<string> incidencias = new List<string>();
                switch (Logica.mostrarNombresIncidencias(incidencias))
                {
                    case 0:
                        cmboxIncidencia.Items.Clear();
                        cmboxIncidencia.Text = null;
                        foreach (string nombre in incidencias)
                        {
                            cmboxIncidencia.Items.Add(nombre);
                        }
                        cmboxIncidencia.Text = incidencias[0];
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
            int setsGanados, puntos, hora, minutos, segundo;
            if (rbPuntos.Checked)
            {
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
                    switch (Logica.InsertarenPuntosNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, minuto, nombre, apelido, ocurrencia))
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
                else
                {

                    MessageBox.Show("Minuto no valido, debe ser un entero");
                }
            }
            else {
                if (rbSets.Checked)
                {
                    if (int.TryParse(txtSetsGanados.Text, out setsGanados))
                    {
                        if (int.TryParse(txtPuntosGanados.Text, out puntos))
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
                            switch (Logica.insertarParticularNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, setsGanados, puntos, nombre, apelido, ocurrencia))
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
                        else
                        {
                            MessageBox.Show("Puntos debe ser un numero entero");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sets ganados debe ser un numero entero");
                    }

                }
                else {
                    if (Int32.TryParse(txtMinutos.Text, out minutos) && Int32.TryParse(txtHoras.Text, out hora) && Int32.TryParse(txtSegundos.Text, out segundo))
                    {
                        if (minutos >= 0 && hora >= 0 && segundo >= 0 && minutos<60 && segundo<60 ) {
                            if (int.TryParse(txtPuntuacion.Text, out puntos))
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
                                string fecha = hora + ":" + minutos + ":" + segundo;
                                switch (Logica.insertarRankingNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, puntos, fecha, nombre, apelido, ocurrencia))
                                {
                                    case 0:
                                        MessageBox.Show("Se registro la incidencia exitosamente");
                                        txtMinuto.Text = null;
                                        txtHoras.Text = null;
                                        txtMinutos.Text = null;
                                        txtSegundos.Text = null;
                                        txtPuntuacion.Text = null;
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
                                MessageBox.Show("Puntuacion debe ser un entero");
                            }
                        }
                        else {
                            MessageBox.Show("Tiempo no válido");
                        }
                    }
                    else {
                        MessageBox.Show("Hora, minuto y segundo deben ser números enteros");
                    }
                }
            }

        }
        

        private void cmboxIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadorEquipo();
        }
        private void mostrar_OcultarPanes() {
            if (rbPuntos.Checked)
            {
                panePuntos.Visible = true;
                paneRanking.Visible = false;
                paneParticular.Visible = false;
            }
            else {
                if (rbSets.Checked)
                {
                    panePuntos.Visible = false;
                    paneRanking.Visible = false;
                    paneParticular.Visible = true;
                }
                else {
                    panePuntos.Visible = false;
                    paneRanking.Visible = true;
                    paneParticular.Visible = false;
                }
            }
        }
     

        private void rbPuntos_CheckedChanged(object sender, EventArgs e)
        {
            this.mostrar_OcultarPanes();
        }

        private void rbSets_CheckedChanged(object sender, EventArgs e)
        {
            this.mostrar_OcultarPanes();
        }

        private void rbRanking_CheckedChanged(object sender, EventArgs e)
        {
            this.mostrar_OcultarPanes();
        }

        private void paneParticular_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panePuntos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
