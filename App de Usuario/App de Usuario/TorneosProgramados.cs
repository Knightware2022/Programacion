﻿using System;
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
        Torneos torneo = new Torneos();
        EncuentrosColectivos encuentros = new EncuentrosColectivos();
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
                    MessageBox.Show(Idiomas.noTorneosProgramados);
                    break;
                default:
                    MessageBox.Show(Idiomas.errorInesperado);
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
                        txtDeporteEvento.Text = null;
                        txtFechaComienzo.Text = null;
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxNombreEvento.Items.Clear();
                        MessageBox.Show(Idiomas.noEventosenTorneo);
                        break;
                    default:
                        txtDeporteEvento.Text = null;
                        txtFechaComienzo.Text = null;
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxJugadoresEquipos.Items.Clear();
                        cmboxNombreEvento.Items.Clear();
                        MessageBox.Show(Idiomas.errorConexion);
                        break;
                }
            }
            else
            {
                MessageBox.Show(Idiomas.ErrorObteniendoID);
            }
        }
        private void DatosTorneo()
        {
            List<string> Equipos = new List<string>();
            int id;
            try
            {
                if (int.TryParse(cmboxTorneos.Text.Substring(0, cmboxTorneos.Text.IndexOf(" ")), out id))
                {
                    torneo.idTorneo = id;
                    switch (ApiResultados.datosTorneosProgramados(torneo, Equipos))
                    {
                        case 0:
                            txtDeporteEvento.Text = torneo.nombreDeporte;
                            txtFechaComienzo.Text = torneo.fechaComienzo.ToString();
                            txtFechaFin.Text = torneo.fechaFinaliza.ToString();

                            cmboxEquiposParticipan.Items.Clear();
                            try
                            {
                                foreach (string nombre in Equipos)
                                {
                                    cmboxEquiposParticipan.Items.Add(nombre);
                                }
                                cmboxEquiposParticipan.Text = Equipos[0];
                            }
                            catch
                            {
                                MessageBox.Show(Idiomas.EventosSinEquipos);
                            }
                            cmboxEquiposParticipan.Text = Equipos[0];

                            break;
                        case 5:
                            txtDeporteEvento.Text = torneo.nombreDeporte;
                            txtFechaComienzo.Text = torneo.fechaComienzo.ToString();
                            txtFechaFin.Text = torneo.fechaFinaliza.ToString();
                            MessageBox.Show(Idiomas.EventosSinEquipos);

                            cmboxEquiposParticipan.Items.Clear();
                            cmboxEquiposParticipan.Text = null;
                            break;
                        default:
                            MessageBox.Show(Idiomas.errorConexion);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.errorInesperado);
                }
            }
            catch {
                MessageBox.Show(Idiomas.ErrorObteniendoID);
            }
        }
        private void refrescarJugadores()
        {
            int id;
            try
            {
                string nombre = cmboxEquiposParticipan.Text.Substring(0, cmboxEquiposParticipan.Text.IndexOf("/"));
                string categoria = cmboxEquiposParticipan.Text.Substring((cmboxEquiposParticipan.Text.IndexOf("/") + 1), (cmboxEquiposParticipan.Text.Length - (cmboxEquiposParticipan.Text.IndexOf("/") + 1)));
                if (int.TryParse(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")), out id))
                {
                    List<string> jugadores = new List<string>();
                    switch (ApiResultados.JugadoresDeEventos(nombre, categoria, id, jugadores))
                    {
                        case 0:
                            cmboxJugadoresEquipos.Items.Clear();
                            foreach (string nombreJugador in jugadores)
                            {
                                cmboxJugadoresEquipos.Items.Add(nombreJugador);
                            }
                            cmboxJugadoresEquipos.Text = jugadores[0];
                            break;
                        default:
                            MessageBox.Show(Idiomas.EquipoSinJugadores);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.errorInesperado);
                }
            }
            catch
            {
                MessageBox.Show(Idiomas.EventosSinEquipos);
            }
        }


        private void TorneosProgramados_Load(object sender, EventArgs e)
        {
            refrescarTorneos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            cmboxJugadoresEquipos.Items.Clear();
            cmboxJugadoresEquipos.Items.Clear();
            cmboxNombreEvento.Items.Clear();
            this.Visible = false;
            Program.frmPrincipal.paneVentanas.Visible = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarTorneos();
            txtDeporteEvento.Text = null;
            txtFechaComienzo.Text = null;
            cmboxJugadoresEquipos.Items.Clear();
            cmboxJugadoresEquipos.Items.Clear();
            cmboxNombreEvento.Items.Clear();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.refrescarEventos();
            this.DatosTorneo();
        }

        private void cmboxNombreEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxEquiposParticipan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refrescarJugadores();
        }
        public void temaTorProg(Color formulario, Color boton, Color letra, Color panel1, Color panel2)
        {
            this.BackColor = formulario;
            paneBuscarEvento.BackColor = panel1;
            lblTorneo.ForeColor = letra;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.BackColor = boton;
            btnRefrescar.ForeColor = letra;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.BackColor = boton;
            btnFiltrar.ForeColor = letra;
            btnFiltrar.FlatAppearance.BorderColor = boton;

            paneEvento.BackColor = panel2;
            lblEvento1.ForeColor = letra;
            lblDeporteEvento.ForeColor = letra;
            lblfechaComienzo.ForeColor = letra;
            lblFechaFin.ForeColor = letra;
            lblEquiposParticipando.ForeColor = letra;
            lblJugadores.ForeColor = letra;
            btnSuscribirse.FlatStyle = FlatStyle.Flat;
            btnSuscribirse.BackColor = boton;
            btnSuscribirse.ForeColor = letra;
            btnSuscribirse.FlatAppearance.BorderColor = boton;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.BackColor = boton;
            btnVolver.ForeColor = letra;
            btnVolver.FlatAppearance.BorderColor = boton;
        }
        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            List<string> idEventos = new List<string>();
            for (int i = 0; i < cmboxNombreEvento.Items.Count; i++) {
                idEventos.Add(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")));
                cmboxNombreEvento.SelectedIndex = i;
                idEventos.Add(cmboxNombreEvento.Text.Substring(0, cmboxNombreEvento.Text.IndexOf(" ")));

            }
            switch (ApiResultados.SuscribirseATorneos(idEventos, txtDeporteEvento.Text, Login.nombreUsuario)) {
                case 0:

                    MessageBox.Show(Idiomas.promesaNotificacionTorneo);
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.promesaNotificacionTorneo);
                    break;
            }
        }
    }
}
