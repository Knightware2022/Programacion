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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }


        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Program.frmResultados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmResultados.Show();
            Program.frmResultados.Bounds = paneVentanas.Bounds;

        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            Program.frmEventosProgramados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmEventosProgramados.Show();
            Program.frmEventosProgramados.Bounds = paneVentanas.Bounds;
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Program.frmDeportesFavoritos.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmDeportesFavoritos.Show();
            Program.frmDeportesFavoritos.Bounds = paneVentanas.Bounds;

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            Program.frmConfiguracion.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmConfiguracion.Show();
            Program.frmConfiguracion.Bounds = paneVentanas.Bounds;
           
        }
    }
}
