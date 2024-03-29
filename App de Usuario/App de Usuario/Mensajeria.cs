﻿using System.Net.Mail;
using System.Net;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public static class Mensajeria
    {

        public static void sendCorreo(string dirCorreo, string contraseña) {
            try
            {
                using (MailMessage mailMessage = new MailMessage()) {
                    mailMessage.To.Add(dirCorreo);
                    mailMessage.Subject = "Restablecimiento de contraseña";
                    mailMessage.Body = "Se ha solicitado un cambio de contraseña.\n" +
                        " Su nueva contraseña es: " + contraseña ;
                    mailMessage.IsBodyHtml = false;

                    mailMessage.From = new MailAddress("noreply@gmail.com", "Cambio de contraseña");
                    using (SmtpClient cliente = new SmtpClient()) {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new NetworkCredential("sisrd2022@gmail.com", "osomthlkbgfzwhsn");
                        cliente.Port = 25;
                        cliente.EnableSsl = true;

                        cliente.Host = "smtp.gmail.com";
                        cliente.Send(mailMessage);
                    }
                    
                }


            }
            catch {
                MessageBox.Show(Idiomas.errorConexion);
            }
        }

        public static void NoticacionEvento(string dirCorreo, string body)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.To.Add(dirCorreo);
                    mailMessage.Subject = "Notificacion de evento";
                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = false;

                    mailMessage.From = new MailAddress("noreply@gmail.com", "Evento");
                    using (SmtpClient cliente = new SmtpClient())
                    {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new NetworkCredential("sisrd2022@gmail.com", "osomthlkbgfzwhsn");
                        cliente.Port = 25;
                        cliente.EnableSsl = true;

                        cliente.Host = "smtp.gmail.com";
                        cliente.Send(mailMessage);
                    }

                }


            }
            catch
            {
            }
        }
    }
}
