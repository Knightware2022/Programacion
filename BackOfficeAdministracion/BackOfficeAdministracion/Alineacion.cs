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
    public partial class Alineacion : Form
    {
        public Alineacion()
        {
            InitializeComponent();
        }

        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {
            this.BackColor = fondo;
            paneAlineacion.BackColor = fondo;
            btnAceptar.BackColor = boton;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = boton;
            btnAceptar.ForeColor = letra;
            btnRefrescar.BackColor = boton;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnRefrescar.ForeColor = letra;
            btnVolver.BackColor = boton;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderColor = boton;
            btnVolver.ForeColor = letra;
            btnVerAli.BackColor = boton;
            btnVerAli.FlatStyle = FlatStyle.Flat;
            btnVerAli.FlatAppearance.BorderColor = boton;
            btnVerAli.ForeColor = letra;
            lblEquipo.ForeColor = letra;
            lblIncidencia.ForeColor = letra;
            lblJugador.ForeColor = letra;
            lstviewAlineacion.BackColor = boton;
            lstviewAlineacion.ForeColor = letra;
        }
        private void Alineacion_Load(object sender, EventArgs e)
        {
            lstviewAlineacion.View = View.Details;
        }
        public void refrescarEquiposCargados()
        {
            List<string> nombresEquipos = new List<string>();
            switch (Logica.EquiposEncuentrosColectivos(GestionarEventos.encuentrosColectivos.idEncuentro, nombresEquipos))
            {
                case 0:
                    cmboxEquipo.Items.Clear();
                    cmboxEquipo.Text = null;
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
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.EventosNOTIENEequipos);
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.equipoNotieneJugadores);
                    break;
            }
        }
        private void refrescarAlineacion()
        {
            List<string> nombrealineaciones = new List<string>();
            switch (Logica.mostrarNombrePosicion(nombrealineaciones))
            {
                case 0:
                    cmboxAlineacion.Items.Clear();
                    cmboxAlineacion.Text = null;
                    foreach (string nombre in nombrealineaciones)
                    {
                        cmboxAlineacion.Items.Add(nombre);
                    }
                    cmboxAlineacion.Text = nombrealineaciones[0];

                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.encuentronotieneAlineacion);
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cmboxJugador.Items.Clear();
            cmboxJugador.Text = null;
            lstviewAlineacion.Items.Clear();
            Program.frmPrincipal.Enabled = true;
            this.Visible = false;

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            lstviewAlineacion.Items.Clear();
            this.refrescarJugadorEquipo();
            this.refrescarAlineacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Nombrej = new List<string>();
            List<string> Apellidoj = new List<string>();
            List<string> Posicionj = new List<string>();
            List<string> Equipoj = new List<string>();

            string nombreEquipo = cmboxEquipo.Text.Substring(0, cmboxEquipo.Text.IndexOf("/"));
            string categoriaEquipo = cmboxEquipo.Text.Substring((cmboxEquipo.Text.IndexOf("/") + 1), (cmboxEquipo.Text.Length - (cmboxEquipo.Text.IndexOf("/") + 1)));
            switch (Logica.mostrarAlineaciondeEquipo(Nombrej, Apellidoj, Posicionj, Equipoj, GestionarEventos.encuentrosColectivos.idEncuentro, nombreEquipo, categoriaEquipo)) {
                case 0:
                    lstviewAlineacion.Items.Clear();
                    for (int i = 0; i < Nombrej.Count; i++) {
                        ListViewItem item = new ListViewItem(Nombrej[i]);
                        item.SubItems.Add(Apellidoj[i]);
                        item.SubItems.Add(Posicionj[i]);
                        item.SubItems.Add(Equipoj[i]);
                        lstviewAlineacion.Items.Add(item);
                    }
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    lstviewAlineacion.Items.Clear();
                    MessageBox.Show(Idiomas.encuentronotieneAlineacion);
                    break;
            }
        }

        private void cmboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadorEquipo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = cmboxJugador.Text.Substring(0, cmboxJugador.Text.IndexOf(" "));
            string apelido = cmboxJugador.Text.Substring((cmboxJugador.Text.IndexOf(" ") + 1), (cmboxJugador.Text.Length - (cmboxJugador.Text.IndexOf(" ") + 1)));
            string posicion = cmboxAlineacion.Text;
            bool bandera = true;
            Random r = new Random();
            int idRandom = 0;
            while (bandera == true) {
                idRandom = r.Next();
                switch (Logica.BuscarIDalineacion(idRandom))
                {
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperadoCoherente);
                        break;
                    case 3:
                        bandera = false;
                        break;
                }

            }
            switch (Logica.insertarAlineacion(GestionarEventos.encuentrosColectivos.idEncuentro, GestionarEventos.encuentrosColectivos.deporteEncuentro, nombre, apelido, posicion, idRandom)) {
                case 0:                  
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
            }
        }
    }
}
