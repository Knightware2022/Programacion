﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public partial class Alineacion : Form
    {
        public Alineacion()
        {
            InitializeComponent();
        }
        EncuentrosColectivos c = new EncuentrosColectivos();
        public void refrescarEquiposCargados()
        {
            List<string> nombresEquipos = new List<string>();
            switch (ApiResultados.ConsultarEquiposAlineacion(Resultados.encuentros.idEncuentro, nombresEquipos))
            {
                case 0:
                    cmboxEquipoAlineacion.Items.Clear();
                    cmboxEquipoAlineacion.Text = null;
                    foreach (string nombre in nombresEquipos)
                    {
                        cmboxEquipoAlineacion.Items.Add(nombre);
                    }
                    cmboxEquipoAlineacion.Text = nombresEquipos[0];
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.EventosSinEquipos);
                    break;
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.refrescarEquiposCargados();
            lstviewAlineacion.Items.Clear();
            pcboxLogo.Image = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Enabled = true;
            this.Visible = false;
        }
        public void mostrarAlineacion() {
            lstviewAlineacion.Items.Clear();
            List<string> Nombrej = new List<string>();
            List<string> Apellidoj = new List<string>();
            List<string> Posicionj = new List<string>();
            List<string> Equipoj = new List<string>();

            string nombreEquipo = cmboxEquipoAlineacion.Text.Substring(0, cmboxEquipoAlineacion.Text.IndexOf("/"));
            string categoriaEquipo = cmboxEquipoAlineacion.Text.Substring((cmboxEquipoAlineacion.Text.IndexOf("/") + 1), (cmboxEquipoAlineacion.Text.Length - (cmboxEquipoAlineacion.Text.IndexOf("/") + 1)));
            switch (Logica.mostrarAlineaciondeEquipoYsuLogo(Nombrej, Apellidoj, Posicionj, Equipoj, Resultados.encuentros.idEncuentro, nombreEquipo, categoriaEquipo, c))
            {
                case 0:
                    for (int i = 0; i < Nombrej.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(Nombrej[i]);
                        item.SubItems.Add(Apellidoj[i]);
                        item.SubItems.Add(Posicionj[i]);
                        item.SubItems.Add(Equipoj[i]);
                        lstviewAlineacion.Items.Add(item);
                    }
                    try
                    {
                        var request = WebRequest.Create(c.nombreDeporte);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pcboxLogo.Image = Bitmap.FromStream(stream);
                        }
                    }
                    catch
                    {

                        this.pcboxLogo.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
                    }
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errorConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 3:
                    lstviewAlineacion.Items.Clear();
                    MessageBox.Show(Idiomas.EquiposSinAlineacion);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.mostrarAlineacion();
        }

        private void cmboxEquipoAlineacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mostrarAlineacion();
        }
        public void temaAli(Color formulario, Color boton, Color letra, Color panel1, Color panel2)
        {
            this.BackColor = formulario;

            paneAlineacion.BackColor = formulario;

            lstviewAlineacion.BackColor = panel2;
            lstviewAlineacion.ForeColor = letra;


            lblEquipo.ForeColor = letra;

            btnVerAlineacion.BackColor = boton;
            btnVerAlineacion.FlatStyle = FlatStyle.Flat;
            btnVerAlineacion.FlatAppearance.BorderColor = boton;
            btnVerAlineacion.ForeColor = letra;
            btnRefrescar.BackColor = boton;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnRefrescar.ForeColor = letra;
            btnVolver.BackColor = boton;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderColor = boton;
            btnVolver.ForeColor = letra;


        }
        private void lstviewAlineacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
