using App_de_Usuario.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    static class Program
    {
        public static Configuracion frmConfiguracion;
        public static Deportes_Favoritos frmDeportesFavoritos;
        public static EventosProgramados frmEventosProgramados;
        public static Login frmLogin;
        public static Principal frmPrincipal;
        public static Resultados frmResultados;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmConfiguracion = new Configuracion();
            frmDeportesFavoritos = new Deportes_Favoritos();
            frmEventosProgramados = new EventosProgramados();
            frmPrincipal = new Principal();
            frmResultados = new Resultados();
            
            Application.Run(frmLogin = new Login());
        }
    }
}
