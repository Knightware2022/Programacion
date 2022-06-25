namespace BackOffice
{
    internal static class Program
    {
        public static SIGED frmSIGED;
        public static Login frmLogin;
        public static GestionarDeportes frmGestionarDeportes;
        public static GestionarEventos frmGestionarEventos;
        public static GestionarUsuarios frmGestionarUsuarios;



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            frmSIGED = new SIGED();
            frmLogin = new Login();
            frmGestionarDeportes = new GestionarDeportes();
            frmGestionarEventos = new GestionarEventos();
            frmGestionarUsuarios = new GestionarUsuarios();
            Application.Run(frmLogin = new Login());

        }
    }
}