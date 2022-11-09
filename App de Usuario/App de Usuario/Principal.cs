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
            publicidad.obtenerPublicidad(123);
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
                catch {
                 
                    this.pboxPublicidad.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
                }
            }
            tiempoSistema.Enabled = true;          

        }

   /*     public void sistemaNotifica() {
            while (true) {
                List<string> nombreEvento = new List<string>();
                List<DateTime> fechaEvento = new List<DateTime>();
                
                Thread.Sleep(1000); //cada cuanto va a comprobar lo de los eventos?....
                switch (ApiResultados.NotificacionEvento(Login.nombreUsuario, nombreEvento, fechaEvento)) {
                    case 0:
                        for (int i = 0; i < nombreEvento.Count; i++) {
                            int minuto = fecha.Minute;
                            int hora = fecha.Hour;
                            int dia = fecha.Day;
                            int mes = fecha.Month;
                            int anio = fecha.Year;
                            if (fecha == fechaEvento[i]) {
                                MessageBox.Show("El siguiente evento ya comenzó: \n           " + nombreEvento[i]);

                            }
                            if (minuto >= 50)
                            {
                                switch (minuto) {
                                    case 50:
                                        minuto = 00;
                                        hora = hora + 1;
                                        if (hora == 24) {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes) {
                                                case 1: case 3: case 5: case 7: case 8:
                                                case 10: case 12:
                                                    if (dia == 32) {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13) {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 51:
                                        minuto = 01;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 52:
                                        minuto = 02;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 53:
                                        minuto = 03;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 54:
                                        minuto = 04;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 55:
                                        minuto = 05;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 56:
                                        minuto = 06;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 57:
                                        minuto = 07;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 58:
                                        minuto = 08;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                    case 59:
                                        minuto = 09;
                                        hora = hora + 1;
                                        if (hora == 24)
                                        {
                                            hora = 00;
                                            dia = dia + 1;
                                            switch (mes)
                                            {
                                                case 1:
                                                case 3:
                                                case 5:
                                                case 7:
                                                case 8:
                                                case 10:
                                                case 12:
                                                    if (dia == 32)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    if (dia == 29)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;
                                                case 4:
                                                case 6:
                                                case 9:
                                                case 11:
                                                    if (dia == 31)
                                                    {
                                                        dia = 01;
                                                        mes = mes + 1;
                                                        if (mes == 13)
                                                        {
                                                            mes = 01;
                                                            anio = anio + 1;
                                                        }
                                                    }
                                                    break;

                                            }
                                        }

                                        fecha.AddDays(dia);
                                        fecha.AddMinutes(minuto);
                                        fecha.AddHours(hora);
                                        fecha.AddMonths(mes);
                                        fecha.AddYears(anio);
                                        break;
                                }
                                if (fechaEvento[i] == fecha)
                                {
                                    MessageBox.Show("El siguiente evento comenzará en 10 minutos: \n           " + nombreEvento[i]);
                                }
                            }
                            else {
                                fecha.AddMinutes(minuto + 10);
                                if (fechaEvento[i] == fecha) {
                                    MessageBox.Show("El siguiente evento comenzará en 10 minutos: \n           " + nombreEvento[i]);
                                }
                            }
                            
                        }
                        break;
                    default:
                        break;
                }
            }
           
        }*/

        public void sistemNot()
        {
            while (true)
            {
                List<string> nombreEvento = new List<string>();
                List<DateTime> fechaEvento = new List<DateTime>();
                Thread.Sleep(5000);
                switch (ApiResultados.NotificacionEvento(Login.nombreUsuario, nombreEvento, fechaEvento))
                {
                    case 0:
                        for (int i = 0; i < nombreEvento.Count; i++)
                        {
                            
                            if (fechaEvento[i].Year == DateTime.Now.Year && fechaEvento[i].Month == DateTime.Now.Month && fechaEvento[i].Day == DateTime.Now.Day && fechaEvento[i].Hour == DateTime.Now.Hour && fechaEvento[i].Minute == DateTime.Now.Minute)
                            {
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
                                        new ToastContentBuilder()
                                                                        .AddArgument("action", "viewConversation")
                                                                        .AddArgument("conversationId", 9813)
                                                                        .AddText("Un evento está por comenzar")
                                                                        .AddText("El evento " + nombreEvento[i] + " comenzará en 10 minutos")
                                                                        .Show();
                                    }
                                    else {
                                        if (fechaEvento[i].Minute == (DateTime.Now.Minute - 10)){
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

        private void pboxPublicidad_Click(object sender, EventArgs e)
        {
            Program.frmRegistrarse.MdiParent = this;
            Program.frmRegistrarse.Show();
            paneVentanas.Visible = false;
            Program.frmRegistrarse.Bounds = paneVentanas.Bounds;

        }

        private void tiempoSistema_Tick(object sender, EventArgs e)
        {/*
            string hola = DateTime.Now.ToString("yyy/MM/dd") + " " + DateTime.Now.ToString("hh:mm:ss");
            fecha = Convert.ToDateTime(hola);
        
            
            fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            MessageBox.Show(fecha.ToString() + " hola");*/
        }
    
    }
}
