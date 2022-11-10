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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        public void tema(int flag)
        {

            Color fondo = new Color();
            Color letra = new Color();
            Color casilla = new Color();
            Color boton = new Color();

            if (flag == 1)
            {
                picboxHome.Image = global::BackOfficeAdministracion.Properties.Resources.HOME;
                paneVista.BackColor = Color.FromName("LemonChiffon");

                fondo = SystemColors.ActiveCaption;
                letra = SystemColors.ControlText;
                casilla = SystemColors.AppWorkspace;
                boton = SystemColors.ButtonFace;


            }
            else
            {
                picboxHome.Image = global::BackOfficeAdministracion.Properties.Resources.HomeOscuro;
                fondo = Color.FromArgb(40, 40, 40);
                letra = Color.FromArgb(200, 200, 200);
                boton = Color.FromArgb(60, 60, 60);
                casilla = Color.FromArgb(70, 70, 70);
                paneVista.BackColor = fondo;
            }
            this.BackColor = fondo;

            paneHerramientas.BackColor = fondo;
            paneGestionarDeportes.BackColor = casilla;
            paneGestionarEventos.BackColor = casilla;
            paneGestionarUsuarios.BackColor = casilla;
            paneVerEventos.BackColor = casilla;
            paneVerResultados.BackColor = casilla;
            paneConfiguracion.BackColor = casilla;

            btnGestionarDeportes.BackColor = boton;
            btnGestionarDeportes.FlatStyle = FlatStyle.Flat;
            btnGestionarDeportes.FlatAppearance.BorderColor = boton;
            btnGestionarDeportes.ForeColor = letra;
            btnGestionarUsuarios.BackColor = boton;
            btnGestionarUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionarUsuarios.FlatAppearance.BorderColor = boton;
            btnGestionarUsuarios.ForeColor = letra;
            btnGestionarEventos.BackColor = boton;
            btnGestionarEventos.FlatStyle = FlatStyle.Flat;
            btnGestionarEventos.FlatAppearance.BorderColor = boton;
            btnGestionarEventos.ForeColor = letra;
            btnGestionarTorneos.BackColor = boton;
            btnGestionarTorneos.FlatStyle = FlatStyle.Flat;
            btnGestionarTorneos.FlatAppearance.BorderColor = boton;
            btnGestionarTorneos.ForeColor = letra;
            btnConfiguracion.BackColor = boton;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.FlatAppearance.BorderColor = boton;
            btnConfiguracion.ForeColor = letra;






        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnGestionarDeportes_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarDeportes.Show();
            Program.frmGestionarDeportes.MdiParent = this;
            Program.frmGestionarDeportes.Location = this.paneVista.Location;
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarUsuarios.Show();
            Program.frmGestionarUsuarios.MdiParent = this;
            Program.frmGestionarUsuarios.Location = this.paneVista.Location;
        }

        private void btnGestionarEventos_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarEventos.Show();
            Program.frmGestionarEventos.MdiParent = this;
            Program.frmGestionarEventos.Location = this.paneVista.Location;
            
        }
        
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmConfiguracion.Show();
            Program.frmConfiguracion.MdiParent = this;
            Program.frmConfiguracion.Location = this.paneVista.Location;
          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//cierra todo
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Logica._cn.Close();
                Application.Exit();
            }
            catch {

            }
           
        }

        private void btnGestionarTorneos_Click(object sender, EventArgs e)
        {
            this.paneVista.Hide();
            Program.frmGestionarTorneos.Show();
            Program.frmGestionarTorneos.MdiParent = this;
            Program.frmGestionarTorneos.Location = this.paneVista.Location;

        }
    }
}
