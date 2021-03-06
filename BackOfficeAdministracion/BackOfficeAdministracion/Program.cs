using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    static class Program
    {
        public static GestionarEventos frmGestionarEventos;
        public static GestionarDeportes frmGestionarDeportes;
        public static GestionarUsuarios frmGestionarUsuarios;
        public static Configuracion frmConfiguracion;
        public static Principal frmPrincipal;

        public static Login frmLogin;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmGestionarEventos = new GestionarEventos();
            frmGestionarDeportes = new GestionarDeportes();
            frmGestionarUsuarios = new GestionarUsuarios();
            frmConfiguracion = new Configuracion();
            frmPrincipal = new Principal();
            Application.Run(frmLogin = new Login());
        }
    }
}
