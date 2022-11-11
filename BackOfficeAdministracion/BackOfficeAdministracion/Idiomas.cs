using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public static class Idiomas
    {
        public static string errorInesperado;
        public static string errordeConexion;
        public static string usuarioOcontraIncorrectos;
        public static string contrasNoCoinciden;
        public static string usuarioActualizado;
        public static string UsuarioNotieneDeportes;
        public static string usuarioCreado;
        public static string usuarioNoexisteCrear;
        public static string deporteCreado;
        public static string nuevaContraEnviada;
        public static string correoNotFound;
        public static string usuarioERAGUEST;
        public static string usuarioEliminado;
        public static string usuarioYaNoExiste;
        public static string titulosBorrarUsuario;
        public static string titulosCrearUsuario;
        public static string crearUsuario;
        public static string correoEnUSo;
        public static string datosNovalidos;
        public static string publicidadAnanida;
        public static string publicidadEliminada;
        public static string crearTorneo;
        public static string torneoCreado;
        public static string tituloCrearTorneo;
        public static string torneoBorrado;
        public static string torneoNotieneEncuentros;
        public static string equipoNotieneJugadores;
        public static string EventosNOTIENEequipos;
        public static string errorInesperadoCoherente;
        public static string noExistenTorneos;
        public static string noEventoSistema;


        public static void CambioIdioma(string idioma) {
            switch (idioma) {
                case "Ingles": case "English":

                    #region frmLogin
                    Program.frmLogin.lblContrasenia.Text = "Password: ";
                    Program.frmLogin.lblCorreo.Text = "Enter your e-mail: ";
                    Program.frmLogin.lblIdioma.Text = "Languaje: ";
                    Program.frmLogin.lblUsuario.Text = "User: ";
                    Program.frmLogin.btnAceptar.Text = "Log-in";
                    Program.frmLogin.btnCancelar.Text = "Cancel";
                    Program.frmLogin.btnCancelarII.Text = "Cancel";
                    Program.frmLogin.btnEnviar.Text = "Send";
                    Program.frmLogin.chkboxOlvide.Text = "Forgot your password?";
                    Program.frmConfiguracion.cmboxIdioma.Text = "English";

                    #endregion


                    #region FrmPrincipal
                    Program.frmPrincipal.btnConfiguracion.Text = "Settings";
                    Program.frmPrincipal.btnGestionarDeportes.Text = "Manage sports, teams and players";
                    Program.frmPrincipal.btnGestionarEventos.Text = "Manage matches";
                    Program.frmPrincipal.btnGestionarTorneos.Text = "Manage tournaments";
                    Program.frmPrincipal.btnGestionarUsuarios.Text = "Manage users and advertising";
                    #endregion

                    #region de frmUsuarios
                    Program.frmGestionarUsuarios.tbpgMostrarUsuarios.Text = "A/B/M users";
                    Program.frmGestionarUsuarios.tbpgMostrarUsuarios.Text = "A/B/M advertising";

                    Program.frmGestionarUsuarios.lblIDusuario.Text = "Username: ";
                    Program.frmGestionarUsuarios.btnRefrescar.Text = "Refresh";
                    Program.frmGestionarUsuarios.btnMostrar.Text = "Search";
                    Program.frmGestionarUsuarios.lblIdUsu.Text = "ID:";
                    Program.frmGestionarUsuarios.lblNombre.Text = "Username";
                    Program.frmGestionarUsuarios.lblCorreo.Text = "e-mail";
                    Program.frmGestionarUsuarios.lblAntiguedad.Text = "subscription time:";
                    Program.frmGestionarUsuarios.lblRol.Text = "Rol: ";
                    Program.frmGestionarUsuarios.lblDeportesFavoritos.Text = "Favorite sports";
                    Program.frmGestionarUsuarios.btnAceptar.Text = "Accept";
                    Program.frmGestionarUsuarios.btnCancelar.Text = "Cancel";
                    Program.frmGestionarUsuarios.btnCrearUsuario.Text = "Create user";
                    Program.frmGestionarUsuarios.btnEnviarCorreo.Text = "Send e-mail";
                    Program.frmGestionarUsuarios.btnEliminar.Text = "Delete";
                    Program.frmGestionarUsuarios.btnCerrar.Text = "Return";

                    Program.frmGestionarUsuarios.lblUrl.Text = " Advertising URL: ";
                    Program.frmGestionarUsuarios.btnAgregarPublicidad.Text = "Add advertising";
                    Program.frmGestionarUsuarios.lblUrlEliminar.Text = "Advertising URL";
                    Program.frmGestionarUsuarios.btnEliminarPublicidad.Text = "Delete advertising";
                    Program.frmGestionarUsuarios.btnRefrescarPublicidad.Text = "Refresh";
                    Program.frmGestionarUsuarios.lblAsignarURL.Text = "URL";
                    Program.frmGestionarUsuarios.lblAsignarUsuario.Text = "Guest";
                    Program.frmGestionarUsuarios.btnAsignar.Text = "Assign";
                    Program.frmGestionarUsuarios.btnCerrar2.Text = "Return";
                    #endregion

                    #region de frmTorneos
                    Program.frmGestionarTorneos.tbpgTorneosColectivos.Text = "A/B/M tournaments";
                    Program.frmGestionarTorneos.lblIDmodificar.Text = "Tournament to modify: ";
                    Program.frmGestionarTorneos.btnRefrescarTorneoColectivo.Text = "Refresh";
                    Program.frmGestionarTorneos.btnBuscar.Text = "Search";
                    Program.frmGestionarTorneos.lblIDEncuentroCole.Text = "Tournament id: ";
                    Program.frmGestionarTorneos.lblDeporte.Text = "Sport: ";
                    Program.frmGestionarTorneos.lblEquiposenEncuentro.Text = "Teams of the tournament";
                    Program.frmGestionarTorneos.lblFechaComienzo.Text = "Start date";
                    Program.frmGestionarTorneos.lblFechaFinalizaCole.Text = "End date";
                    Program.frmGestionarTorneos.lblHoraComienzo.Text = "Start time";
                    Program.frmGestionarTorneos.lblHoraComienza.Text = "Hr";
                    Program.frmGestionarTorneos.lblMinutosComienza.Text = "Minutes";
                    Program.frmGestionarTorneos.lblFinalizaColectivo.Text = "End time";
                    Program.frmGestionarTorneos.lblHoraFinalizaColec.Text = "Hr";
                    Program.frmGestionarTorneos.lblMinutoFinCole.Text = "Minutes";
                    Program.frmGestionarTorneos.lblDescripcionColect.Text = "Tournament name";
                    Program.frmGestionarTorneos.btnEncuentros.Text = "Matches";
                    Program.frmGestionarTorneos.btnAceptarCambios.Text = "Apply";
                    Program.frmGestionarTorneos.btnLimpiarCampos.Text = "Cancel";
                    Program.frmGestionarTorneos.btnDelete.Text = "Delete";
                    Program.frmGestionarTorneos.btnClose.Text = "Return";
                    Program.frmGestionarTorneos.btnCrearTorneo.Text = "Create tournament";
                    #endregion

                    #region de frmEventos
                    Program.frmGestionarEventos.tbpgModificar.Text = "A/B/M matches";

                    Program.frmGestionarEventos.lblIDmodificar.Text = "Match to modify: ";
                    Program.frmGestionarEventos.btnRefrescarEncuentroColectivo.Text = "Refresh";
                    Program.frmGestionarEventos.btnBuscar.Text = "Search";
                    Program.frmGestionarEventos.btnAceptar.Text = "Apply";
                    Program.frmGestionarEventos.btnEliminar.Text = "Delete";
                    Program.frmGestionarEventos.btnCancelar.Text = "Cancel";
                    Program.frmGestionarEventos.btnCerrar.Text = "Return";
                    Program.frmGestionarEventos.btnCrearEventoColectivo.Text = "Create";
                    Program.frmGestionarEventos.btnIncidencias.Text = "Incidents";
                    Program.frmGestionarEventos.btnAlineacion.Text = "Alignment";

                    Program.frmGestionarEventos.lblIDEncuentroCole.Text = "Match id";
                    Program.frmGestionarEventos.lblDeporte.Text = "Sport";
                    Program.frmGestionarEventos.lblEquiposenEncuentro.Text = "Teams in match";
                    Program.frmGestionarEventos.lblEquiposenSistema.Text = "Teams in system";
                    Program.frmGestionarEventos.lblFechaComienzo.Text = "Start date";
                    Program.frmGestionarEventos.lblFechaFinalizaCole.Text = "End date";
                    Program.frmGestionarEventos.lblFinalizaColectivo.Text = "End time";
                    Program.frmGestionarEventos.lblHoraComienzo.Text = "Start time";
                    Program.frmGestionarEventos.lblHoraComienza.Text = "Hr";
                    Program.frmGestionarEventos.lblMinutosComienza.Text = "Minutes";
                    Program.frmGestionarEventos.lblHoraFinalizaColec.Text = "Hr";
                    Program.frmGestionarEventos.lblMinutoFinCole.Text = "Minutes";
                    Program.frmGestionarEventos.lblDescripcionColect.Text = "Name of the match";

                    #endregion

                    #region de frmEventosTorneos
                    Program.frmEncuentrosTorneos.lblFiltro.Text = "Filter event by sport";
                    Program.frmEncuentrosTorneos.lblEquiposEnEncuentro.Text = "Teams in the match";
                    Program.frmEncuentrosTorneos.lblFechaComienzo.Text = "Start date";
                    Program.frmEncuentrosTorneos.lblHoraFinaliza.Text = "End date";
                    Program.frmEncuentrosTorneos.lblNombreEncuentro.Text = "Name of the match";
                    Program.frmEncuentrosTorneos.btnAgregar.Text = "Add to tournament";
                    Program.frmEncuentrosTorneos.btnFiltrar.Text = "Filter";
                    Program.frmEncuentrosTorneos.btnVolver.Text = "Return";
                    Program.frmEncuentrosTorneos.btnVerCargados.Text = "Tournament matches";
                    Program.frmEncuentrosTorneos.btnQuitar.Text = "Delete";
                    Program.frmEncuentrosTorneos.btnRefrescar.Text = "Refresh";

                    #endregion

                    #region de frmIncidenicas
                    Program.frmIncidencias.lblEquipo.Text = "Team";
                    Program.frmIncidencias.lblJugador.Text = "Player";
                    Program.frmIncidencias.lblIncidencia.Text = "Incidence";
                    Program.frmIncidencias.lblMinuto.Text = "Minute";
                    Program.frmIncidencias.lblPuntos.Text = "Points";
                    Program.frmIncidencias.rbPuntos.Text = "Points";
                    Program.frmIncidencias.gboxModoPuntuacion.Text = "Punctuation system";
                    Program.frmIncidencias.btnAceptar.Text ="Insert";
                    Program.frmIncidencias.btnRefrescar.Text = "Refresh";
                    Program.frmIncidencias.btnVolver.Text = "Return";

                    #endregion

                    #region de frmAlineacion
                    Program.frmAlineacion.lblEquipo.Text = "Team";
                    Program.frmAlineacion.lblJugador.Text = "Players";
                    Program.frmAlineacion.lblIncidencia.Text = "Alignment";
                    Program.frmAlineacion.btnAceptar.Text = "Assign position";
                    Program.frmAlineacion.btnRefrescar.Text = "Refresh";
                    Program.frmAlineacion.btnVerAli.Text = "Show alignment";
                    Program.frmAlineacion.btnVolver.Text = "Return";
                    Program.frmAlineacion.lstviewAlineacion.Columns.Clear();

                    ColumnHeader columna0 = new ColumnHeader();
                    columna0.Text ="Name";
                    columna0.TextAlign = HorizontalAlignment.Center;
                    columna0.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(columna0);
                    ColumnHeader columna1 = new ColumnHeader();
                    columna1.Text = "Last name";
                    columna1.TextAlign = HorizontalAlignment.Center;
                    columna1.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(columna1);
                    ColumnHeader columna2 = new ColumnHeader();
                    columna2.Text = "Position";
                    columna2.TextAlign = HorizontalAlignment.Center;
                    columna2.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(columna2);
                    ColumnHeader columna3 = new ColumnHeader();
                    columna3.Text = "Team";
                    columna3.TextAlign = HorizontalAlignment.Center;
                    columna3.Width = 50;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(columna3);
                    #endregion

                    #region de frmConfiguracion
                    Program.frmConfiguracion.lblIdioma.Text = "Languaje";
                    Program.frmConfiguracion.lblApariencia.Text = "Theme";
                    Program.frmConfiguracion.lblContra.Text = "Password";
                    Program.frmConfiguracion.lblIdiomaE.Text = "Choose a languaje";
                    Program.frmConfiguracion.lblTema.Text = "Theme to apply";
                    Program.frmConfiguracion.lblContraActual.Text = "Current password";
                    Program.frmConfiguracion.lblNuevaContra.Text = "New password";
                    Program.frmConfiguracion.lblRepContra.Text = "Repeat password";
                    Program.frmConfiguracion.btnAplicar.Text = "Apply changes";
                    Program.frmConfiguracion.btnCambiarContraseña.Text = "Change password";
                    Program.frmConfiguracion.btnCerrar.Text = "Return";
                    #endregion

                    #region de frmGestionarDeporte
                    Program.frmGestionarDeportes.tbpgModificar.Text = "A/B/M Sports";
                    Program.frmGestionarDeportes.lblIdeporte.Text = "Sport name";
                    Program.frmGestionarDeportes.btnBuscar.Text = "Search";
                    Program.frmGestionarDeportes.btnRefrescarDeportes.Text = "Refresh";
                    Program.frmGestionarDeportes.lblIDdeporte.Text = "ID";
                    Program.frmGestionarDeportes.lblMcategoria.Text = "Category";
                    Program.frmGestionarDeportes.lblMnombre.Text = "Name";
                    Program.frmGestionarDeportes.lblEquiposDeporte.Text = "Teams practicing";
                    Program.frmGestionarDeportes.btnModificar.Text = "Apply";
                    Program.frmGestionarDeportes.btnMcancelar.Text = "Cancel";
                    Program.frmGestionarDeportes.btnCerrarI.Text = "Return";
                    Program.frmGestionarDeportes.btnEliminar.Text = "Delete";
                    Program.frmGestionarDeportes.btnCrearDeporte.Text = "Create sport";

                    Program.frmGestionarDeportes.tbpgModificarEquipo.Text = "A/B/M teams";
                    Program.frmGestionarDeportes.lblIDequipo.Text = "Team name";
                    Program.frmGestionarDeportes.btnBuscarEquipo.Text = "Search";
                    Program.frmGestionarDeportes.btnRefrescar.Text = "Refresh";
                    Program.frmGestionarDeportes.lblID.Text = "Team id";
                    Program.frmGestionarDeportes.lblNombreEquipo.Text = "Name";
                    Program.frmGestionarDeportes.lblDeporteEquipo.Text = "Sport to which he is dedicated";
                    Program.frmGestionarDeportes.lblCategoriaEquipo.Text = "Category";
                    Program.frmGestionarDeportes.lblCantidadJugadoresEquipo.Text = "Number of players";
                    Program.frmGestionarDeportes.lblLogo.Text = "Logo";
                    Program.frmGestionarDeportes.lblPais.Text = "Country";
                    Program.frmGestionarDeportes.lblNombreJugador.Text = "Players in system";
                    Program.frmGestionarDeportes.lblListaJugadores.Text = "Players of the team";
                    Program.frmGestionarDeportes.btnAgregarJugador.Text = "Add to team";
                    Program.frmGestionarDeportes.btnEliminarJugador.Text = "delete from team";
                    Program.frmGestionarDeportes.btnRefrescarJugadores.Text = "Refresh";
                    Program.frmGestionarDeportes.btnAplicar.Text = "Apply";
                    Program.frmGestionarDeportes.btnCancelar.Text = "Cancel";
                    Program.frmGestionarDeportes.btnEliminarEquipo.Text = "Delete";
                    Program.frmGestionarDeportes.btnCrearEquipos.Text = "Create";
                    Program.frmGestionarDeportes.btnCerrar.Text = "Return";

                    Program.frmGestionarDeportes.tbpgABMjugadores.Text = "A/B/M Players";
                    Program.frmGestionarDeportes.lblIDJugador.Text = "Name of player";
                    Program.frmGestionarDeportes.btnBuscarID.Text = "Search player";
                    Program.frmGestionarDeportes.btnRefrescarLista.Text = "Refresh";
                    Program.frmGestionarDeportes.lblIDjugadores.Text = "Players id";
                    Program.frmGestionarDeportes.lblNombreJugadores.Text = "Name";
                    Program.frmGestionarDeportes.lblApellidoJugadores.Text = "Last name";
                    Program.frmGestionarDeportes.lblSexo.Text = "Sex";
                    Program.frmGestionarDeportes.lblEdadJugadores.Text = "Age";
                    Program.frmGestionarDeportes.lblPaisNacimientoJugadores.Text = "Country of birth";
                    Program.frmGestionarDeportes.btnAplicarCambios.Text = "Apply";
                    Program.frmGestionarDeportes.btnCancelarJugador.Text = "Cancel";
                    Program.frmGestionarDeportes.btnCrearJugador.Text = "Create";
                    Program.frmGestionarDeportes.btnCerrarIII.Text = "Return";
                    Program.frmGestionarDeportes.btnBorrarJugador.Text = "Delete player";

                    #endregion

                    break;

                case "Spanish": case "Español":
                    #region frmLogin
                    Program.frmLogin.lblContrasenia.Text = "Contraseña: ";
                    Program.frmLogin.lblCorreo.Text = "Ingrese su correo electrónico: ";
                    Program.frmLogin.lblIdioma.Text = "Idioma: ";
                    Program.frmLogin.lblUsuario.Text = "Usuario: ";
                    Program.frmLogin.btnAceptar.Text = "Ingresar";
                    Program.frmLogin.btnCancelar.Text = "Cancelar";
                    Program.frmLogin.btnCancelarII.Text = "Cancelar";
                    Program.frmLogin.btnEnviar.Text = "Enviar";
                    Program.frmLogin.chkboxOlvide.Text = "Olvidó su contraseña?";
                    Program.frmConfiguracion.cmboxIdioma.Text = "Español";
                    #endregion

                    #region FrmPrincipal
                    Program.frmPrincipal.btnConfiguracion.Text = "Configuracion";
                    Program.frmPrincipal.btnGestionarDeportes.Text = "Gestionar Deportes, equipos y jugadores";
                    Program.frmPrincipal.btnGestionarEventos.Text = "Gestionar Encuentros";
                    Program.frmPrincipal.btnGestionarTorneos.Text = "Gestionar Torneos";
                    Program.frmPrincipal.btnGestionarUsuarios.Text = "Gestionar Usuarios y Publicidad";
                    #endregion

                    #region de frmUsuarios
                    Program.frmGestionarUsuarios.tbpgMostrarUsuarios.Text = "A/B/M usuarios";
                    Program.frmGestionarUsuarios.tbpgMostrarUsuarios.Text = "A/B/M publicidad";

                    Program.frmGestionarUsuarios.lblIDusuario.Text = "Nombre de usuario: ";
                    Program.frmGestionarUsuarios.btnRefrescar.Text = "Refrescar";
                    Program.frmGestionarUsuarios.btnMostrar.Text = "Buscar";
                    Program.frmGestionarUsuarios.lblIdUsu.Text = "ID:";
                    Program.frmGestionarUsuarios.lblNombre.Text = "Nombre de usuario";
                    Program.frmGestionarUsuarios.lblCorreo.Text = "Correo electrónico";
                    Program.frmGestionarUsuarios.lblAntiguedad.Text = "Tiempo suscripto";
                    Program.frmGestionarUsuarios.lblRol.Text = "Rol: ";
                    Program.frmGestionarUsuarios.lblDeportesFavoritos.Text = "Deportes favoritos";
                    Program.frmGestionarUsuarios.btnAceptar.Text = "Aceptar";
                    Program.frmGestionarUsuarios.btnCancelar.Text = "Cancelar";
                    Program.frmGestionarUsuarios.btnCrearUsuario.Text = "Crear";
                    Program.frmGestionarUsuarios.btnEnviarCorreo.Text = "Enviar correo";
                    Program.frmGestionarUsuarios.btnEliminar.Text = "Eliminar";
                    Program.frmGestionarUsuarios.btnCerrar.Text = "Volver";

                    Program.frmGestionarUsuarios.lblUrl.Text = "URL de publicidad: ";
                    Program.frmGestionarUsuarios.btnAgregarPublicidad.Text = "Añadir publicidad";
                    Program.frmGestionarUsuarios.lblUrlEliminar.Text = "URL de publicidad:";
                    Program.frmGestionarUsuarios.btnEliminarPublicidad.Text = "Eliminar publicidad";
                    Program.frmGestionarUsuarios.btnRefrescarPublicidad.Text = "Refrescar";
                    Program.frmGestionarUsuarios.lblAsignarURL.Text = "URL";
                    Program.frmGestionarUsuarios.lblAsignarUsuario.Text = "Id usuario guest";
                    Program.frmGestionarUsuarios.btnAsignar.Text = "Asignar";
                    Program.frmGestionarUsuarios.btnCerrar2.Text = "Volver";
                    #endregion

                    #region de frmTorneos
                    Program.frmGestionarTorneos.tbpgTorneosColectivos.Text = "A/B/M torneos";
                    Program.frmGestionarTorneos.lblIDmodificar.Text = "Torneo a modificar: ";
                    Program.frmGestionarTorneos.btnRefrescarTorneoColectivo.Text = "Refrescar";
                    Program.frmGestionarTorneos.btnBuscar.Text = "Buscar";
                    Program.frmGestionarTorneos.lblIDEncuentroCole.Text = "Id torneo: ";
                    Program.frmGestionarTorneos.lblDeporte.Text = "Deporte: ";
                    Program.frmGestionarTorneos.lblEquiposenEncuentro.Text = "Equipos del torneo";
                    Program.frmGestionarTorneos.lblFechaComienzo.Text = "Fecha de comienzo";
                    Program.frmGestionarTorneos.lblFechaFinalizaCole.Text = "Fecha de finalización";
                    Program.frmGestionarTorneos.lblHoraComienzo.Text = "Hora comienzo";
                    Program.frmGestionarTorneos.lblHoraComienza.Text = "Hs";
                    Program.frmGestionarTorneos.lblMinutosComienza.Text = "Minutos";
                    Program.frmGestionarTorneos.lblFinalizaColectivo.Text = "Hora de finalización";
                    Program.frmGestionarTorneos.lblHoraFinalizaColec.Text = "Hs";
                    Program.frmGestionarTorneos.lblMinutoFinCole.Text = "Minutos";
                    Program.frmGestionarTorneos.lblDescripcionColect.Text = "Nombre del torneo";
                    Program.frmGestionarTorneos.btnEncuentros.Text = "Encuentros";
                    Program.frmGestionarTorneos.btnAceptarCambios.Text = "Aceptar";
                    Program.frmGestionarTorneos.btnLimpiarCampos.Text = "Cancelar";
                    Program.frmGestionarTorneos.btnDelete.Text = "Eliminar";
                    Program.frmGestionarTorneos.btnClose.Text = "Volver";
                    Program.frmGestionarTorneos.btnCrearTorneo.Text = "Crear torneo";
                    #endregion

                    #region de frmEventos
                    Program.frmGestionarEventos.tbpgModificar.Text = "A/B/M eventos";

                    Program.frmGestionarEventos.lblIDmodificar.Text = "Evento a modificar: ";
                    Program.frmGestionarEventos.btnRefrescarEncuentroColectivo.Text = "Refrescar";
                    Program.frmGestionarEventos.btnBuscar.Text = "Buscar";
                    Program.frmGestionarEventos.btnAceptar.Text = "Aceptar";
                    Program.frmGestionarEventos.btnEliminar.Text = "Eliminar";
                    Program.frmGestionarEventos.btnCancelar.Text = "Cancelar";
                    Program.frmGestionarEventos.btnCerrar.Text = "Volver";
                    Program.frmGestionarEventos.btnCrearEventoColectivo.Text = "Crear";
                    Program.frmGestionarEventos.btnIncidencias.Text = "Incidencias";
                    Program.frmGestionarEventos.btnAlineacion.Text = "Alineacion";

                    Program.frmGestionarEventos.lblIDEncuentroCole.Text = "id de encuentro: ";
                    Program.frmGestionarEventos.lblDeporte.Text = "Deporte";
                    Program.frmGestionarEventos.lblEquiposenEncuentro.Text = "Equipos en encuentro";
                    Program.frmGestionarEventos.lblEquiposenSistema.Text = "Equipos en sistema";
                    Program.frmGestionarEventos.lblFechaComienzo.Text = "Fecha de comienzo";
                    Program.frmGestionarEventos.lblFechaFinalizaCole.Text = "Fecha de finalización";
                    Program.frmGestionarEventos.lblFinalizaColectivo.Text = "Hora de finalización";
                    Program.frmGestionarEventos.lblHoraComienzo.Text = "Hora comienzo";
                    Program.frmGestionarEventos.lblHoraComienza.Text = "Hs";
                    Program.frmGestionarEventos.lblMinutosComienza.Text = "Minutos";
                    Program.frmGestionarEventos.lblHoraFinalizaColec.Text = "Hs";
                    Program.frmGestionarEventos.lblMinutoFinCole.Text = "Minutos";
                    Program.frmGestionarEventos.lblDescripcionColect.Text = "Nombre/Descripción del encuentro";

                    #endregion

                    #region de frmEventosTorneos
                    Program.frmEncuentrosTorneos.lblFiltro.Text = "Filtrar eventos por deporte";
                    Program.frmEncuentrosTorneos.lblEquiposEnEncuentro.Text = "Equipos en evento";
                    Program.frmEncuentrosTorneos.lblFechaComienzo.Text = "Fecha de comienzo";
                    Program.frmEncuentrosTorneos.lblHoraFinaliza.Text = "Fecha de finalización";
                    Program.frmEncuentrosTorneos.lblNombreEncuentro.Text = "Nombre del encuentro";
                    Program.frmEncuentrosTorneos.btnAgregar.Text = "Agregar al torneo";
                    Program.frmEncuentrosTorneos.btnFiltrar.Text = "Filtrar";
                    Program.frmEncuentrosTorneos.btnVolver.Text = "Volver";
                    Program.frmEncuentrosTorneos.btnVerCargados.Text = "Encuentros en el torneo";
                    Program.frmEncuentrosTorneos.btnQuitar.Text = "Quitar del torneo";
                    Program.frmEncuentrosTorneos.btnRefrescar.Text = "Refrescar ";

                    #endregion

                    #region de frmIncidenicas
                    Program.frmIncidencias.lblEquipo.Text = "Equipo";
                    Program.frmIncidencias.lblJugador.Text = "Jugador";
                    Program.frmIncidencias.lblIncidencia.Text = "Incidencia";
                    Program.frmIncidencias.lblMinuto.Text = "Minuto";
                    Program.frmIncidencias.lblPuntos.Text = "Puntos";
                    Program.frmIncidencias.rbPuntos.Text = "Puntos";
                    Program.frmIncidencias.gboxModoPuntuacion.Text = "Sistema de puntuación";
                    Program.frmIncidencias.btnAceptar.Text = "Ingresar";
                    Program.frmIncidencias.btnRefrescar.Text = "Refrescar";
                    Program.frmIncidencias.btnVolver.Text = "Volver";

                    #endregion

                    #region de frmIncidenicas
                    Program.frmIncidencias.lblEquipo.Text = "Team";
                    Program.frmIncidencias.lblJugador.Text = "Player";
                    Program.frmIncidencias.lblIncidencia.Text = "Incidence";
                    Program.frmIncidencias.lblMinuto.Text = "Minute";
                    Program.frmIncidencias.lblPuntos.Text = "Points";
                    Program.frmIncidencias.rbPuntos.Text = "Points";
                    Program.frmIncidencias.gboxModoPuntuacion.Text = "Punctuation system";
                    Program.frmIncidencias.btnAceptar.Text = "Insert";
                    Program.frmIncidencias.btnRefrescar.Text = "Refresh";
                    Program.frmIncidencias.btnVolver.Text = "Return";

                    #endregion

                    #region de frmAlineacion
                    Program.frmAlineacion.lblEquipo.Text = "Equipo";
                    Program.frmAlineacion.lblJugador.Text = "Jugador";
                    Program.frmAlineacion.lblIncidencia.Text = "Alineación";
                    Program.frmAlineacion.btnAceptar.Text = "Asignar posición";
                    Program.frmAlineacion.btnRefrescar.Text = "Refrescar";
                    Program.frmAlineacion.btnVerAli.Text = "Mostrar alineación";
                    Program.frmAlineacion.btnVolver.Text = "Volver";
                    Program.frmAlineacion.lstviewAlineacion.Columns.Clear();

                    ColumnHeader c0 = new ColumnHeader();
                    c0.Text = "Nombre";
                    c0.TextAlign = HorizontalAlignment.Center;
                    c0.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(c0);
                    ColumnHeader c1 = new ColumnHeader();
                    c1.Text = "Apellido";
                    c1.TextAlign = HorizontalAlignment.Center;
                    c1.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(c1);
                    ColumnHeader c2 = new ColumnHeader();
                    c2.Text = "Posición";
                    c2.TextAlign = HorizontalAlignment.Center;
                    c2.Width = 80;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(c2);
                    ColumnHeader c3 = new ColumnHeader();
                    c3.Text = "Equipo";
                    c3.TextAlign = HorizontalAlignment.Center;
                    c3.Width = 50;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(c3);
                    #endregion

                    #region de frmConfiguracion
                    Program.frmConfiguracion.lblIdioma.Text = "Lenguaje";
                    Program.frmConfiguracion.lblApariencia.Text = "Apariencia";
                    Program.frmConfiguracion.lblContra.Text = "Contraseña";
                    Program.frmConfiguracion.lblIdiomaE.Text = "Escoja un lenguaje";
                    Program.frmConfiguracion.lblTema.Text = "Tema a aplicar";
                    Program.frmConfiguracion.lblContraActual.Text = "Contraseña actual";
                    Program.frmConfiguracion.lblNuevaContra.Text = "Nueva Contraseña";
                    Program.frmConfiguracion.lblRepContra.Text = "Repita Contraseña";
                    Program.frmConfiguracion.btnAplicar.Text = "Aplicar cambios";
                    Program.frmConfiguracion.btnCambiarContraseña.Text = "Cambiar contraseña";
                    Program.frmConfiguracion.btnCerrar.Text = "Volver";
                    #endregion

                    #region de frmGestionarDeporte
                    Program.frmGestionarDeportes.tbpgModificar.Text = "A/B/M Deportes";
                    Program.frmGestionarDeportes.lblIdeporte.Text = "Nombre del deporte";
                    Program.frmGestionarDeportes.btnBuscar.Text = "Buscar";
                    Program.frmGestionarDeportes.btnRefrescarDeportes.Text = "Refrescar";
                    Program.frmGestionarDeportes.lblIDdeporte.Text = "ID";
                    Program.frmGestionarDeportes.lblMcategoria.Text = "Categoria";
                    Program.frmGestionarDeportes.lblMnombre.Text = "Nombre";
                    Program.frmGestionarDeportes.lblEquiposDeporte.Text = "Equipos que lo practican";
                    Program.frmGestionarDeportes.btnModificar.Text = "Aplicar";
                    Program.frmGestionarDeportes.btnMcancelar.Text = "Cancelar";
                    Program.frmGestionarDeportes.btnCerrarI.Text = "Volver";
                    Program.frmGestionarDeportes.btnEliminar.Text = "Eliminar";
                    Program.frmGestionarDeportes.btnCrearDeporte.Text = "Crear deporte";

                    Program.frmGestionarDeportes.tbpgModificarEquipo.Text = "A/B/M Equipos";
                    Program.frmGestionarDeportes.lblIDequipo.Text = "Nombre de equipo";
                    Program.frmGestionarDeportes.btnBuscarEquipo.Text = "Buscar";
                    Program.frmGestionarDeportes.btnRefrescar.Text = "Refrescar";
                    Program.frmGestionarDeportes.lblID.Text = "ID de equipo";
                    Program.frmGestionarDeportes.lblNombreEquipo.Text = "Nombre";
                    Program.frmGestionarDeportes.lblDeporteEquipo.Text = "Deporte al que se dedica";
                    Program.frmGestionarDeportes.lblCategoriaEquipo.Text = "Categoria";
                    Program.frmGestionarDeportes.lblCantidadJugadoresEquipo.Text = "Número de jugadores";
                    Program.frmGestionarDeportes.lblLogo.Text = "Logo";
                    Program.frmGestionarDeportes.lblPais.Text = "Pais";
                    Program.frmGestionarDeportes.lblNombreJugador.Text = "Jugadores en sistema";
                    Program.frmGestionarDeportes.lblListaJugadores.Text = "Jugadores en el equipo";
                    Program.frmGestionarDeportes.btnAgregarJugador.Text = "Agregar al equipo";
                    Program.frmGestionarDeportes.btnEliminarJugador.Text = "Quitar de equipo";
                    Program.frmGestionarDeportes.btnRefrescarJugadores.Text = "Refrescar";
                    Program.frmGestionarDeportes.btnAplicar.Text = "Aplicar";
                    Program.frmGestionarDeportes.btnCancelar.Text = "Cancelar";
                    Program.frmGestionarDeportes.btnEliminarEquipo.Text = "Eliminar";
                    Program.frmGestionarDeportes.btnCrearEquipos.Text = "Crear";
                    Program.frmGestionarDeportes.btnCerrar.Text = "Volver";

                    Program.frmGestionarDeportes.tbpgABMjugadores.Text = "A/B/M Jugadores";
                    Program.frmGestionarDeportes.lblIDJugador.Text = "Nombe del jugador";
                    Program.frmGestionarDeportes.btnBuscarID.Text = "Buscar jugador";
                    Program.frmGestionarDeportes.btnRefrescarLista.Text = "Refrescar";
                    Program.frmGestionarDeportes.lblIDjugadores.Text = "Id del Jugador";
                    Program.frmGestionarDeportes.lblNombreJugadores.Text = "Nombre";
                    Program.frmGestionarDeportes.lblApellidoJugadores.Text = "Apellido";
                    Program.frmGestionarDeportes.lblSexo.Text = "Sexo";
                    Program.frmGestionarDeportes.lblEdadJugadores.Text = "Edad";
                    Program.frmGestionarDeportes.lblPaisNacimientoJugadores.Text = "País de nacimiento";
                    Program.frmGestionarDeportes.btnAplicarCambios.Text = "Aplicar";
                    Program.frmGestionarDeportes.btnCancelarJugador.Text = "Cancelar";
                    Program.frmGestionarDeportes.btnCrearJugador.Text = "Crear";
                    Program.frmGestionarDeportes.btnCerrarIII.Text = "Volver";
                    Program.frmGestionarDeportes.btnBorrarJugador.Text = "Eliminar jugador";

                    #endregion

                    #region de variables

                     errorInesperado = "Error inesperado";
                    errorInesperadoCoherente = "Error inesperado, verifique que los datos sean coherentes";

                    errordeConexion = "Error de conexion";
                   usuarioOcontraIncorrectos = "Usuario y/o contraseña incorrectos";
                   contrasNoCoinciden = "Las contraseñas no coinciden";
                    usuarioActualizado = "Usuario actualizado";
                   UsuarioNotieneDeportes = "El usuario no tiene deportes favoritos";
                   usuarioCreado = "El usuario fue creado, contraseña por de 0-9";
                    usuarioNoexisteCrear = "El usuario no existe, desea crearlo?";
                     deporteCreado = "El deporte fue creado";
                    correoNotFound = "Correo no encontrado";
                    nuevaContraEnviada = "Una nueva contraseña fue enviada a su correo";
                    usuarioERAGUEST = "El usuario es GUEST, desea eliminarlo? ";
                    usuarioEliminado = "El usuario fue eliminado";
                    titulosBorrarUsuario = "Eliminar usuario";
                    titulosCrearUsuario = "Crear usuario";
                    crearUsuario = "El usuario no existe desea crearlo?";
                    datosNovalidos = "Error, datos no válidos";
                    correoEnUSo = "Correo o disponible";
                    publicidadAnanida = "Publicidad añadida";
                    publicidadEliminada = "Publicidad Eliminada";

                    crearTorneo = "El torneo no existe desea crearlo?";
                   torneoCreado = "Torneo creado";
                   tituloCrearTorneo = "Crear torneo";
                  torneoBorrado = "Torneo eliminado";
                  torneoNotieneEncuentros = "El torneo no tiene encuentros";
                  equipoNotieneJugadores = "El equipos no tiene jugadores";
                    EventosNOTIENEequipos = "El evento no posee equipos";
                    noEventoSistema = "No existen eventos en el sistema";
                    noExistenTorneos = "No existen torneos en el sistema";
                    #endregion

                    break;
            }
        }
    }
}
