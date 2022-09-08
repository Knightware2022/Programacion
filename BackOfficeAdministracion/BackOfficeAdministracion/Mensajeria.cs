using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public static class Mensajeria
    {
        public static void sendCorreo(string dirCorreo, string contraseña)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.To.Add(dirCorreo);
                    mailMessage.Subject = "Restablecimiento de contraseña";
                    mailMessage.Body = "Se ha solicitado un cambio de contraseña.\n";
                    mailMessage.Body += "Su nueva contraseña es: " + contraseña;
                        
                    mailMessage.IsBodyHtml = false;

                    mailMessage.From = new MailAddress("noreply@gmail.com", "Cambio de contraseña");
                    using (SmtpClient cliente = new SmtpClient())
                    {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new NetworkCredential("sisrd2022@gmail.com", "osomthlkbgfzwhsn");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;

                        cliente.Host = "smtp.gmail.com";
                        cliente.Send(mailMessage);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error enviando el correo");
            }
        }
        public static void sendCorreo2(string dirCorreo, string titulo, string cuerpo)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.To.Add(dirCorreo);
                    mailMessage.Subject = titulo;
                    mailMessage.Body = cuerpo;

                    mailMessage.IsBodyHtml = false;

                    mailMessage.From = new MailAddress("noreply@gmail.com", "Aviso importante");
                    using (SmtpClient cliente = new SmtpClient())
                    {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new NetworkCredential("sisrd2022@gmail.com", "osomthlkbgfzwhsn");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;

                        cliente.Host = "smtp.gmail.com";
                        cliente.Send(mailMessage);
                    }
                    MessageBox.Show("Correo enviado exitosamente");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error enviando el correo");
            }
        }
    }
}
