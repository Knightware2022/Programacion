﻿using System;
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


        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {


            this.BackColor = fondo;
            lblEquipo.ForeColor = letra;
            lblJugador.ForeColor = letra;
            lblIncidencia.ForeColor = letra;
            lblMinuto.ForeColor = letra;
            txtMinuto.BackColor = casilla;
            txtMinuto.ForeColor = letra;
            lblPuntos.ForeColor = letra;
            txtPuntos.BackColor = casilla;
            txtPuntos.ForeColor = letra;
            btnAceptar.BackColor = boton;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = boton;
            btnAceptar.ForeColor = letra;
            btnVolver.BackColor = boton;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderColor = boton;
            btnVolver.ForeColor = letra;
            btnRefrescar.BackColor = boton;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnRefrescar.ForeColor = letra;
            gboxModoPuntuacion.ForeColor = letra;

        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            this.rbPuntos.Checked = true;
            this.mostrar_OcultarPanesCmobx();
            this.refrescarEquiposCargados();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Enabled = true;
            this.Visible = false;
            
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.EventosNOTIENEequipos);
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.noJugadoresCargados);
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
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperadoCoherente);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.encuENTROnotieneOcurrencias);
                        break;
                }
            }
        }
            
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarIncidencias();
            this.refrescarJugadorEquipo();
            txtMinuto.Text = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int puntos = 0;
            string nombre = cmboxJugador.Text.Substring(0, cmboxJugador.Text.IndexOf(" "));
            string apelido = cmboxJugador.Text.Substring((cmboxJugador.Text.IndexOf(" ") + 1), (cmboxJugador.Text.Length - (cmboxJugador.Text.IndexOf(" ") + 1)));
            string ocurrencia = cmboxIncidencia.Text;
            if (rbPuntos.Checked)
            {
                int minuto;
                if (Int32.TryParse(txtMinuto.Text, out minuto) && minuto>=0 && Int32.TryParse(txtPuntos.Text, out puntos))
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
                                MessageBox.Show(Idiomas.errorInesperadoCoherente);
                                break;
                            case 3:
                                bandera = false;
                                break;
                        }
                    }
                    switch (Logica.InsertarIncidenciasNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, minuto, nombre, apelido, ocurrencia, puntos))
                    {
                        case 0:
                            MessageBox.Show("Se registro la incidencia exitosamente");
                            txtMinuto.Text = null;
                            this.refrescarJugadorEquipo();
                            this.refrescarIncidencias();
                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 2:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 3:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 4:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                    }
                }
                else
                {

                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                }
            }
            else {
                if (rbSets.Checked)
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
                                MessageBox.Show(Idiomas.errorInesperado);
                                break;
                            case 3:
                                bandera = false;
                                break;
                        }
                    }
                    switch (Logica.InsertarIncidenciasNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, 0, nombre, apelido, ocurrencia, puntos))
                    {
                        case 0:
                            MessageBox.Show("Se registro la incidencia exitosamente");
                            txtMinuto.Text = null;
                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 2:
                            MessageBox.Show(Idiomas.errorInesperadoCoherente);
                            break;
                        case 3:
                            MessageBox.Show(Idiomas.errorInesperadoCoherente);
                            break;
                        case 4:
                            MessageBox.Show(Idiomas.errorInesperadoCoherente);
                            break;

                    }
                }
                else
                {
                    if (int.TryParse(txtPuntos.Text, out puntos))
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
                                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                                    break;
                                case 3:
                                    bandera = false;
                                    break;
                            }
                        }

                        switch (Logica.InsertarIncidenciasNotifica(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, idRandom, 0, nombre, apelido, ocurrencia, puntos))
                        {
                            case 0:
                                MessageBox.Show("Se registro la incidencia exitosamente");
                                txtMinuto.Text = null;
                                break;
                            case 1:
                                MessageBox.Show(Idiomas.errordeConexion);
                                break;
                            case 2:
                                MessageBox.Show(Idiomas.errorInesperadoCoherente);
                                break;
                            case 3:
                                MessageBox.Show(Idiomas.errorInesperadoCoherente);
                                break;
                            case 4:
                                MessageBox.Show(Idiomas.errorInesperadoCoherente);
                                break;
                        }
                    }
                    else {
                        MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    }
                }
            }

        }
        

        private void cmboxIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxIncidencia.Text == "sumar puntos" || cmboxIncidencia.Text == "Puntaje en el ranking")
            {
                panePuntuacion.Enabled = true;
            }
            else {
                panePuntuacion.Enabled = false;
            }
        }

        private void cmboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadorEquipo();
        }
        private void mostrar_OcultarPanesCmobx() {
            txtMinuto.Text = null;
            this.refrescarEquiposCargados();
            this.refrescarIncidencias();
            this.refrescarJugadorEquipo();
            if (rbPuntos.Checked)
            {
                txtMinuto.Enabled = true ;
                panePuntuacion.Enabled = false;
                cmboxJugador.Enabled = true;
            }
            else {
                if (rbSets.Checked)
                {
                    panePuntuacion.Enabled = false;
                    txtMinuto.Enabled = false;
                    cmboxJugador.Enabled = false;
                }
                else {
                    txtMinuto.Enabled = false;
                    panePuntuacion.Enabled = true;
                    cmboxJugador.Enabled = false;
                }
            }
        }
     

        private void rbPuntos_CheckedChanged(object sender, EventArgs e)
        {
            this.mostrar_OcultarPanesCmobx();
            txtPuntos.Text = "0";
        }

        private void rbSets_CheckedChanged(object sender, EventArgs e)
        {
            txtPuntos.Text = "0";

            this.mostrar_OcultarPanesCmobx();
        }

        private void rbRanking_CheckedChanged(object sender, EventArgs e)
        {
            txtPuntos.Text = "0";

            this.mostrar_OcultarPanesCmobx();
        }

        private void paneParticular_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panePuntos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
