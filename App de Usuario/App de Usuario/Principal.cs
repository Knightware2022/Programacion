using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public partial class Principal : Form
    {
        Thread notifica2;
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e){
            notifica2 = new Thread(sistemNot);
            notifica2.Start();

            this.IsMdiContainer = true;
            ApiPublicidad publicidad = new ApiPublicidad();
            try {
                publicidad.obtenerPublicidad(Login.mac);
                if (publicidad.publicidad.url == "Error34X_Publicidad") {
                }
                else {
                    try
                    {
                        var request = WebRequest.Create(publicidad.publicidad.url);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pboxPublicidad.Image = Bitmap.FromStream(stream);
                        }

                    }

                    catch
                    {

                        this.pboxPublicidad.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
                    }
                }
            }
            catch {

            }
            tiempoSistema.Enabled = true;          

        }

        public void sistemNot()
        {
            Usuario u = new Usuario();
            u.nombre = Login.nombreUsuario;
            ApiResultados.BuscarCorreo(u);
            while (true)
            {
                List<string> nombreEvento = new List<string>();
                List<DateTime> fechaEvento = new List<DateTime>();
                switch (ApiResultados.NotificacionEvento(Login.nombreUsuario, nombreEvento, fechaEvento))
                {
                    case 0:
                        for (int i = 0; i < nombreEvento.Count; i++)
                        {
                            if (fechaEvento[i].Year == DateTime.Now.Year && fechaEvento[i].Month == DateTime.Now.Month && fechaEvento[i].Day == DateTime.Now.Day && fechaEvento[i].Hour == DateTime.Now.Hour && fechaEvento[i].Minute == DateTime.Now.Minute)
                            {
                                string envio = Idiomas.eventoComenzo + " " + nombreEvento[i];
                                Mensajeria.NoticacionEvento(u.correo, envio);
                                MessageBox.Show(envio);
                            }
                            else
                            {//si todo es igual menos los minutos

                                if (fechaEvento[i].Year == DateTime.Now.Year && fechaEvento[i].Month == DateTime.Now.Month && fechaEvento[i].Day == DateTime.Now.Day && fechaEvento[i].Hour == DateTime.Now.Hour)
                                {
                                    if (fechaEvento[i].Minute == (DateTime.Now.Minute + 10))
                                    {
                                        string envio = Idiomas.eventoComienza + " " + nombreEvento[i];

                                        Mensajeria.NoticacionEvento(u.correo, envio);
                                        MessageBox.Show(envio);

                                     
                                    }
                                    else
                                    {
                                        if (fechaEvento[i].Minute == (DateTime.Now.Minute - 10))
                                        {
                                            string envio = Idiomas.evento10MInComenzo + " " + nombreEvento[i];

                                            Mensajeria.NoticacionEvento(u.correo, envio);
                                            MessageBox.Show(envio);

                                        }
                                    }
                                }
                                

                            }
                        }

                        break;

                }
                Thread.Sleep(50000);//cada 50 segundos

            }

        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            try
            {
                notifica2.Abort();
                Application.Exit();
                Logica._cn.Close();
            }
            catch {

            }

          
        }

        public void temaPrincipal(Color formulario, Color boton, Color letra, Color panel1, Color panel2)
        {
            this.BackColor = formulario;
            paneBotones.BackColor = panel1;
            paneAvatar.BackColor = panel1;
            btnResultados.FlatStyle = FlatStyle.Flat;
            btnResultados.FlatAppearance.BorderColor = boton;
            btnResultados.BackColor = boton;
            btnResultados.ForeColor = letra;
            btnTorneos.FlatStyle = FlatStyle.Flat;
            btnTorneos.FlatAppearance.BorderColor = boton;
            btnTorneos.BackColor = boton;
            btnTorneos.ForeColor = letra;
            btnFavoritos.FlatStyle = FlatStyle.Flat;
            btnFavoritos.FlatAppearance.BorderColor = boton;
            btnFavoritos.BackColor = boton;
            btnFavoritos.ForeColor = letra;
            btnEncuentros.FlatStyle = FlatStyle.Flat;
            btnEncuentros.FlatAppearance.BorderColor = boton;
            btnEncuentros.BackColor = boton;
            btnEncuentros.ForeColor = letra;
            paneVentanas.BackColor = panel2;
            paneBanner.BackColor = panel1;
        }


        private void btnResultados_Click(object sender, EventArgs e)
        {
            Program.frmResultados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmResultados.Visible = true;
            Program.frmResultados.Bounds = paneVentanas.Bounds;

        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            Program.frmEventosProgramados.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmEventosProgramados.Visible = true;
            Program.frmEventosProgramados.Bounds = paneVentanas.Bounds;
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Program.frmDeportesFavoritos.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmDeportesFavoritos.Visible = true;
            Program.frmDeportesFavoritos.Bounds = paneVentanas.Bounds;

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            Program.frmConfiguracion.MdiParent = this;
            paneVentanas.Visible = false;
            Program.frmConfiguracion.Visible = true;
            Program.frmConfiguracion.Bounds = paneVentanas.Bounds;
           
        }

        private void pboxPublicidad_Click(object sender, EventArgs e)
        {
            Program.frmRegistrarse.MdiParent = this;
            Program.frmRegistrarse.Visible = true;
            paneVentanas.Visible = false;
            Program.frmRegistrarse.Bounds = paneVentanas.Bounds;

        }

        private void tiempoSistema_Tick(object sender, EventArgs e)
        {
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            Program.frmTorneosProgramados.MdiParent = this;
            Program.frmTorneosProgramados.Visible = true;
            paneVentanas.Visible = false;
            Program.frmTorneosProgramados.Bounds = paneVentanas.Bounds;
        }
    }
}
