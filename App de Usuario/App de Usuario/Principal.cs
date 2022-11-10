using Microsoft.Toolkit.Uwp.Notifications;
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
                Thread.Sleep(50000);//cada 50 segundos
                switch (ApiResultados.NotificacionEvento(Login.nombreUsuario, nombreEvento, fechaEvento))
                {
                    case 0:
                        for (int i = 0; i < nombreEvento.Count; i++)
                        {
                            
                            if (fechaEvento[i].Year == DateTime.Now.Year && fechaEvento[i].Month == DateTime.Now.Month && fechaEvento[i].Day == DateTime.Now.Day && fechaEvento[i].Hour == DateTime.Now.Hour && fechaEvento[i].Minute == DateTime.Now.Minute)
                            {
                                string envio = "El evento " + nombreEvento[i] + " acaba de comenzar";
                                Mensajeria.NoticacionEvento(u.correo, envio);
                                new ToastContentBuilder()
                                                                .AddArgument("action", "viewConversation")
                                                                .AddArgument("conversationId", 9813)
                                                                .AddText("Un evento comenzó")
                                                                .AddText("El evento " + nombreEvento[i] + " acaba de comenzar")
                                                                .Show();
                            }
                            else
                            {//si todo es igual menos los minutos

                                if (fechaEvento[i].Year == DateTime.Now.Year && fechaEvento[i].Month == DateTime.Now.Month && fechaEvento[i].Day == DateTime.Now.Day && fechaEvento[i].Hour == DateTime.Now.Hour) {
                                    if (fechaEvento[i].Minute == (DateTime.Now.Minute + 10))
                                    {
                                        string envio = "El evento " + nombreEvento[i] + " comenzará en 10 minutos";

                                        Mensajeria.NoticacionEvento(u.correo, envio);

                                        new ToastContentBuilder()
                                                                        .AddArgument("action", "viewConversation")
                                                                        .AddArgument("conversationId", 9813)
                                                                        .AddText("Un evento está por comenzar")
                                                                        .AddText("El evento " + nombreEvento[i] + " comenzará en 10 minutos")
                                                                        .Show();
                                    }
                                    else {
                                        if (fechaEvento[i].Minute == (DateTime.Now.Minute - 10)){
                                            string envio = "El evento " + nombreEvento[i] + " comenzó hace 10 minutos";

                                            Mensajeria.NoticacionEvento(u.correo, envio);

                                            new ToastContentBuilder()
                                                                            .AddArgument("action", "viewConversation")
                                                                            .AddArgument("conversationId", 9813)
                                                                            .AddText("Un evento comenzó")
                                                                            .AddText("El evento " + nombreEvento[i] + " comenzó hace 10 minutos")
                                                                            .Show();
                                        }
                                    }
                                }
                            }

                        }
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("Error de unexpected");
                        break;
                    case 3:
                        MessageBox.Show("No hay eventos?");
                        break;
                }
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
