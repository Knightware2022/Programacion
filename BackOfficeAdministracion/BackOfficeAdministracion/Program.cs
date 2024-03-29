﻿using System;
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
        public static Alineacion frmAlineacion;
        public static Incidencias frmIncidencias;
        public static GestionarTorneos frmGestionarTorneos;
        public static EncuentrosTorneos frmEncuentrosTorneos;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmGestionarEventos = new GestionarEventos();
            frmGestionarDeportes = new GestionarDeportes();
            frmGestionarUsuarios = new GestionarUsuarios();
            frmConfiguracion = new Configuracion();
            frmIncidencias = new Incidencias();
            frmPrincipal = new Principal();
            frmAlineacion = new Alineacion();
            frmGestionarTorneos = new GestionarTorneos();
            frmEncuentrosTorneos = new EncuentrosTorneos();
            Application.Run(frmLogin = new Login());
        }
    }
}
