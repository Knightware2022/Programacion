using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    static class Idiomas
    {
        public static void cambiarIdioma(string idioma) {
            switch (idioma) {
                case "Ingles":
                case "English":
                    #region "idioma de frmPrincipal"
                    Program.frmPrincipal.btnEncuentros.Text = "Matchs";
                    Program.frmPrincipal.btnFavoritos.Text = "Favorite team";
                    Program.frmPrincipal.btnResultados.Text = "Results";
                    Program.frmPrincipal.btnTorneos.Text = "Tournament";

                    #endregion
                    #region "de frmLogin"
                    Program.frmLogin.btnCancelar.Text = "Cancel";
                    Program.frmLogin.btnGuest.Text = "Guest";
                    Program.frmLogin.btnIngresar.Text = "Log-in";
                    Program.frmLogin.btnRegistrarse.Text = "Sign-in";
                    Program.frmLogin.btnRegistro.Text = "Sign-up";
                    Program.frmLogin.lblNombreUsuario.Text = "User: ";
                    Program.frmLogin.lblUsuario.Text = "User: ";
                    Program.frmLogin.lblCorreo.Text = "Email: ";
                    Program.frmLogin.lblRegistroUsuario.Text = "Password: ";
                    Program.frmLogin.lblConfirmarContrasenia.Text = "Confirm Password: ";
                    Program.frmLogin.lblContrasenia.Text = "Password: ";
                    Program.frmLogin.lblCambiarIdioma.Text = "Language";
                    Program.frmLogin.lblCambiarIdiomaII.Text = "Language";
                    Program.frmLogin.chkboxOlvide.Text = "Forgot password?";
                    Program.frmLogin.lblOlvide.Text = "Enter your email";
                    Program.frmLogin.btnCancelarContraseña.Text = "Cancel";
                    Program.frmLogin.btnEnviar.Text = "Send";

                    Program.frmLogin.cmboxCambiarIdiomaII.Text = "English";
                    Program.frmConfiguracion.cmboxIdiomas.Text = "English";
                    Program.frmLogin.cmboxIdioma.Text = "English";
                    
                    #endregion

                    #region "de frmConfiguracion"
                    Program.frmConfiguracion.lblPerfil.Text = "Profile";
                    Program.frmConfiguracion.lblNombreUsuario.Text = "Username: ";
                    Program.frmConfiguracion.lblApariencia.Text = "Appearance: ";
                    Program.frmConfiguracion.lblAvatar.Text = "Avatar: ";
                    Program.frmConfiguracion.lblContrasenia.Text = "Password: ";
                    Program.frmConfiguracion.lblCorreoElectronico.Text = "Email: ";
                    Program.frmConfiguracion.lblIdioma.Text = "Language";
                    Program.frmConfiguracion.lblTema.Text = "Theme";
                    Program.frmConfiguracion.lblSeleccioneIdioma.Text = "Choose language";
                    Program.frmConfiguracion.btnCancelar.Text = "Return";
                    Program.frmConfiguracion.btnCambiarCorreo.Text = "Change";
                    Program.frmConfiguracion.btnCambiarContrasenia.Text = "Change";
                    Program.frmConfiguracion.btnCambiarAvatar.Text = "pre-view";
                    Program.frmConfiguracion.btnAplicarCambios.Text = "Apply changes";

                    Program.frmConfiguracion.cmboxAvatares.Items.Clear();
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Standar");
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Woman");
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Man");
                    Program.frmConfiguracion.cmboxAvatares.Text = "Standar";
                    Program.frmConfiguracion.cmboxTema.Items.Clear();
                    Program.frmConfiguracion.cmboxTema.Items.Add("Default");
                    Program.frmConfiguracion.cmboxTema.Items.Add("Dark");
                    Program.frmConfiguracion.cmboxTema.Items.Add("Light");
                    Program.frmConfiguracion.cmboxTema.Text = "Default";



                    #endregion

                    #region de frmDeportesFavoritos
                    Program.frmDeportesFavoritos.lblDeportesDisponibles.Text = "Sports available";
                    Program.frmDeportesFavoritos.lblDeportesFavoritos.Text = "Favorite sports";
                    Program.frmDeportesFavoritos.lblEquipos.Text = "Teams available";
                    Program.frmDeportesFavoritos.lblEquiposFav.Text = "Favorite teams";
                    Program.frmDeportesFavoritos.btnRefrescar.Text = "Refresh";
                    Program.frmDeportesFavoritos.btnRefrescarEqui.Text = "Refresh";
                    Program.frmDeportesFavoritos.btnAgregarDeporteFavorito.Text = "Make favorite";
                    Program.frmDeportesFavoritos.btnEliminarFavoritos.Text = "Delete favorite";
                    Program.frmDeportesFavoritos.btnEquiposNoFAv.Text = "Delete favorite";
                    Program.frmDeportesFavoritos.btnVolver.Text = "Close";



                    #endregion

                    #region de frmEventosProgramados
                    Program.frmEventosProgramados.lblDeporte.Text = "Sports: ";
                    Program.frmEventosProgramados.lblEquipo.Text = "Teams: ";
                    Program.frmEventosProgramados.btnRefrescar.Text = "Refresh";
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filter";
                    Program.frmEventosProgramados.grboxFiltros.Text ="Filter by";
                    Program.frmEventosProgramados.rbDeporte.Text = "Sport";
                    Program.frmEventosProgramados.rbEquipo.Text = "Team";
                    Program.frmEventosProgramados.rbTodoslosFiltros.Text = "All filters";
                    Program.frmEventosProgramados.lblEvento1.Text = "Name of the match";
                    Program.frmEventosProgramados.lblDeporteEvento.Text = "Sport of the match";
                    Program.frmEventosProgramados.lblfechaComienzo.Text = "Start date ";
                    Program.frmEventosProgramados.lblFechaFin.Text = "End date";
                    Program.frmEventosProgramados.lblEquiposParticipando.Text = "Teams in the match";
                    Program.frmEventosProgramados.lblJugadores.Text = "Players of the team";
                    Program.frmEventosProgramados.btnVolver.Text = "Return";
                    Program.frmEventosProgramados.btnSuscribirse.Text = "To subscribe";
                    #endregion

                    #region de frmTorneos
                    Program.frmTorneosProgramados.lblTorneo.Text = "Tournament: ";
                    Program.frmTorneosProgramados.btnRefrescar.Text = "Refresh";
                    Program.frmTorneosProgramados.btnFiltrar.Text = "Search";
                    Program.frmTorneosProgramados.lblDeporteEvento.Text = "Matchs in the tournament: ";
                    Program.frmTorneosProgramados.lblDeporteEvento.Text = "Sport of the tournament: ";
                    Program.frmTorneosProgramados.lblfechaComienzo.Text = "Start date: ";
                    Program.frmTorneosProgramados.lblFechaFin.Text = "End date: ";
                    Program.frmTorneosProgramados.lblJugadores.Text = "Players of the team: ";
                    Program.frmTorneosProgramados.lblEquiposParticipando.Text = "Teams of the tournament: ";
                    Program.frmTorneosProgramados.btnSuscribirse.Text = "To subscribe tournament";
                    Program.frmTorneosProgramados.btnVolver.Text = "Return";
                    #endregion

                    #region de frmEncuentrosJugando
                    Program.frmResultados.lblDeporte.Text = "Sports: ";
                    Program.frmResultados.lblEquipo.Text = "Teams: ";
                    Program.frmResultados.btnRefrescar.Text = "Refresh";
                    Program.frmResultados.btnFiltrar.Text = "Filter";
                    Program.frmResultados.grboxFiltros.Text = "Filter by";
                    Program.frmResultados.rbDeporte.Text = "Sport";
                    Program.frmResultados.rbEquipo.Text = "Team";
                    Program.frmResultados.rbTodoslosFiltros.Text = "All filters";
                    Program.frmResultados.lblEvento1.Text = "Name of the match";
                    Program.frmResultados.lblDeporteEvento.Text = "Sport of the match";
                    Program.frmResultados.lblfechaComienzo.Text = "Start date ";
                    Program.frmResultados.lblFechaFin.Text = "End date";
                    Program.frmResultados.lblEquiposParticipando.Text = "Teams in the match";
                    Program.frmResultados.btnIncidencias.Text = "Incidents";
                    Program.frmResultados.btnAlineacion.Text = "Alignment";
                    Program.frmResultados.btnVolver.Text = "Return";
                    Program.frmResultados.gboxResultados.Text = "other results";
                    Program.frmResultados.rbPuntos.Text = "Points";
                    Program.frmResultados.lstResultado.Columns.Clear();

                    ColumnHeader columnHeader0 = new ColumnHeader();
                    columnHeader0.Text = "Teams";
                    columnHeader0.TextAlign = HorizontalAlignment.Center;
                    columnHeader0.Width = 83;
                    Program.frmResultados.lstResultado.Columns.Add(columnHeader0);
                    ColumnHeader columnHeader1 = new ColumnHeader();
                    columnHeader1.Text = "Points";
                    columnHeader1.TextAlign = HorizontalAlignment.Center;
                    columnHeader1.Width = 150;
                    Program.frmResultados.lstResultado.Columns.Add(columnHeader1);
                    ColumnHeader columnHeader2 = new ColumnHeader();
                    columnHeader2.Text = "Won sets";
                    columnHeader2.TextAlign = HorizontalAlignment.Center;
                    columnHeader2.Width = 100;
                    Program.frmResultados.lstResultado.Columns.Add(columnHeader2);


                    #endregion

                    #region de frmIncidencias
                    Program.frmIncidencias.lblEquipo.Text = "Teams: ";
                    Program.frmIncidencias.btnRefrescar.Text = "Refresh";
                    Program.frmIncidencias.btnVolver.Text = "Return";
                    Program.frmIncidencias.btnIncidencias.Text = "Show incidents";

                    Program.frmIncidencias.lstviewIncidencias.Columns.Clear();

                    ColumnHeader chI0 = new ColumnHeader();
                    chI0.Text = "Name";
                    chI0.TextAlign = HorizontalAlignment.Center;
                    chI0.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chI0);

                    ColumnHeader chI1 = new ColumnHeader();
                    chI1.Text = "Last name";
                    chI1.TextAlign = HorizontalAlignment.Center;
                    chI1.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chI1);

                    ColumnHeader chI2 = new ColumnHeader();
                    chI2.Text = "event";
                    chI2.TextAlign = HorizontalAlignment.Center;
                    chI2.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chI2);

                    ColumnHeader chI3 = new ColumnHeader();
                    chI3.Text = "Minute";
                    chI3.TextAlign = HorizontalAlignment.Center;
                    chI3.Width = 50;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chI3);

                    ColumnHeader chI4 = new ColumnHeader();
                    chI4.Text = "Added points";
                    chI4.TextAlign = HorizontalAlignment.Center;
                    chI4.Width = 240;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chI4);

                    #endregion


                    #region de frmAlineacion
                    Program.frmAlineacion.lblEquipo.Text = "Teams: ";
                    Program.frmAlineacion.btnRefrescar.Text = "Refresh";
                    Program.frmAlineacion.btnVolver.Text = "Return";
                    Program.frmAlineacion.btnVerAlineacion.Text = "Show alignment";

                    Program.frmAlineacion.lstviewAlineacion.Columns.Clear();

                    ColumnHeader chAI0 = new ColumnHeader();
                    chAI0.Text = "Name";
                    chAI0.TextAlign = HorizontalAlignment.Center;
                    chAI0.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAI0);

                    ColumnHeader chAI1 = new ColumnHeader();
                    chAI1.Text = "Last name";
                    chAI1.TextAlign = HorizontalAlignment.Center;
                    chAI1.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAI1);

                    ColumnHeader chAI2 = new ColumnHeader();
                    chAI2.Text = "Position";
                    chAI2.TextAlign = HorizontalAlignment.Center;
                    chAI2.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAI2);

                    ColumnHeader chAI3 = new ColumnHeader();
                    chAI3.Text = "Team";
                    chAI3.TextAlign = HorizontalAlignment.Center;
                    chAI3.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAI3);

                    #endregion


                    break;
                case "Español": case "Spanish":
                    #region "de frmPrincipal"
                    Program.frmPrincipal.btnEncuentros.Text = "Encuentros";
                    Program.frmPrincipal.btnFavoritos.Text = "Equipos favoritos";
                    Program.frmPrincipal.btnResultados.Text = "Resultados";
                    Program.frmPrincipal.btnTorneos.Text = "Torneos";
                    #endregion
                    #region "de frmLogin"
                    Program.frmLogin.btnCancelar.Text = "Cancelar";
                    Program.frmLogin.btnGuest.Text = "Guest";
                    Program.frmLogin.btnIngresar.Text = "Ingresar";
                    Program.frmLogin.btnRegistrarse.Text = "Registrarse";
                    Program.frmLogin.btnRegistro.Text = "Registrarse";
                    Program.frmLogin.lblNombreUsuario.Text = "Usuario: ";
                    Program.frmLogin.lblUsuario.Text = "Usuario: ";
                    Program.frmLogin.lblCorreo.Text = "Correo electrónico: ";
                    Program.frmLogin.lblRegistroUsuario.Text = "Contraseña: ";
                    Program.frmLogin.lblConfirmarContrasenia.Text = "Confirmar contraseña: ";
                    Program.frmLogin.lblContrasenia.Text = "Contraseña: ";
                    Program.frmLogin.lblCambiarIdioma.Text = "Lenguaje";
                    Program.frmLogin.lblCambiarIdiomaII.Text = "Lenguaje";
                    Program.frmLogin.chkboxOlvide.Text = "Olvidó su contraseña?";
                    Program.frmLogin.lblOlvide.Text = "Ingrese su correo electrónico";
                    Program.frmLogin.btnCancelarContraseña.Text = "Cancelar";
                    Program.frmLogin.btnEnviar.Text = "Enviar";

                    Program.frmLogin.cmboxCambiarIdiomaII.Text = "Español";
                    Program.frmConfiguracion.cmboxIdiomas.Text = "Español";
                    Program.frmLogin.cmboxIdioma.Text = "Español";
                    
                    #endregion

                    #region "de frmConfiguracion"
                    Program.frmConfiguracion.lblPerfil.Text = "Perfil";
                    Program.frmConfiguracion.lblNombreUsuario.Text = "Nombre de usuario: ";
                    Program.frmConfiguracion.lblApariencia.Text = "Apariencia: ";
                    Program.frmConfiguracion.lblAvatar.Text = "Avatar: ";
                    Program.frmConfiguracion.lblContrasenia.Text = "Contraseña: ";
                    Program.frmConfiguracion.lblCorreoElectronico.Text = "Correo electrónico: ";
                    Program.frmConfiguracion.lblIdioma.Text = "Idioma";
                    Program.frmConfiguracion.lblTema.Text = "Tema";
                    Program.frmConfiguracion.lblSeleccioneIdioma.Text = "Seleccionar idioma";
                    Program.frmConfiguracion.btnCancelar.Text = "Cerrar";
                    Program.frmConfiguracion.btnCambiarCorreo.Text = "Cambiar";
                    Program.frmConfiguracion.btnCambiarContrasenia.Text = "Cambiar";
                    Program.frmConfiguracion.btnCambiarAvatar.Text = "Vista previa";
                    Program.frmConfiguracion.btnAplicarCambios.Text = "Aplicar cambios";

                    Program.frmConfiguracion.cmboxAvatares.Items.Clear();
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Estándar");
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Femenino");
                    Program.frmConfiguracion.cmboxAvatares.Items.Add("Masculino");
                    Program.frmConfiguracion.cmboxAvatares.Text = "Estándar";
                    Program.frmConfiguracion.cmboxTema.Items.Clear();
                    Program.frmConfiguracion.cmboxTema.Items.Add("Por defecto");
                    Program.frmConfiguracion.cmboxTema.Items.Add("Oscuro");
                    Program.frmConfiguracion.cmboxTema.Items.Add("Claro");
                    Program.frmConfiguracion.cmboxTema.Text = "Por defecto";

                    #endregion

                    #region de frmDeportesFavoritos

                    Program.frmDeportesFavoritos.lblDeportesDisponibles.Text = "Deportes disponibles";
                    Program.frmDeportesFavoritos.lblDeportesFavoritos.Text = "Deportes favoritos";
                    Program.frmDeportesFavoritos.lblEquipos.Text = "Equipos disponibles";
                    Program.frmDeportesFavoritos.lblEquiposFav.Text = "Equipos favoritos";
                    Program.frmDeportesFavoritos.btnRefrescar.Text = "Refrescar";
                    Program.frmDeportesFavoritos.btnRefrescarEqui.Text = "Refrescar";
                    Program.frmDeportesFavoritos.btnAgregarDeporteFavorito.Text = "Agregar favorito";
                    Program.frmDeportesFavoritos.btnEliminarFavoritos.Text = "Eliminar favorito";
                    Program.frmDeportesFavoritos.btnEquiposNoFAv.Text = "Eliminar favorito";
                    Program.frmDeportesFavoritos.btnVolver.Text = "Volver";

                    #endregion

                    #region de frmEventosProgramados

                    Program.frmEventosProgramados.lblDeporte.Text = "Deportes: ";
                    Program.frmEventosProgramados.lblEquipo.Text = "Equipos: ";
                    Program.frmEventosProgramados.btnRefrescar.Text = "Refrescar";
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filtrar";
                    Program.frmEventosProgramados.grboxFiltros.Text = "Filtrar por";
                    Program.frmEventosProgramados.rbDeporte.Text = "Deporte";
                    Program.frmEventosProgramados.rbEquipo.Text = "Equipo";
                    Program.frmEventosProgramados.rbTodoslosFiltros.Text = "Todos los filtros";
                    Program.frmEventosProgramados.lblEvento1.Text = "Nombre del encuentro";
                    Program.frmEventosProgramados.lblDeporteEvento.Text = "Deporte del encuentro";
                    Program.frmEventosProgramados.lblfechaComienzo.Text = "Fecha de comienzo";
                    Program.frmEventosProgramados.lblFechaFin.Text = "Fecha de finalización";
                    Program.frmEventosProgramados.lblEquiposParticipando.Text = "Equipos que participan";
                    Program.frmEventosProgramados.lblJugadores.Text = "Jugadores del equipo";
                    Program.frmEventosProgramados.btnVolver.Text = "Volver";
                    Program.frmEventosProgramados.btnSuscribirse.Text = "Suscribirse";
                    #endregion

                    #region de frmTorneos
                    Program.frmTorneosProgramados.lblTorneo.Text = "Torneo: ";
                    Program.frmTorneosProgramados.btnRefrescar.Text = "Refrescar";
                    Program.frmTorneosProgramados.btnFiltrar.Text = "Buscar";
                    Program.frmTorneosProgramados.lblDeporteEvento.Text = "Encuentros del torneo: ";
                    Program.frmTorneosProgramados.lblDeporteEvento.Text = "Deporte del torneo: ";
                    Program.frmTorneosProgramados.lblfechaComienzo.Text = "Fecha comienzo del torneo: ";
                    Program.frmTorneosProgramados.lblFechaFin.Text = "Fecha finalizacion del torneo: ";
                    Program.frmTorneosProgramados.lblJugadores.Text = "Jugadores del equipo ";
                    Program.frmTorneosProgramados.lblEquiposParticipando.Text = "Equipos en el torneo: ";
                    Program.frmTorneosProgramados.btnSuscribirse.Text = "Suscribirse al torneo";
                    Program.frmTorneosProgramados.btnVolver.Text = "Volver";
                    #endregion

                    #region de frmEncuentrosJugando
                    Program.frmResultados.lblDeporte.Text = "Deportes: ";
                    Program.frmResultados.lblEquipo.Text = "Equipos: ";
                    Program.frmResultados.btnRefrescar.Text = "Refrescar";
                    Program.frmResultados.btnFiltrar.Text = "Filtrar";
                    Program.frmResultados.grboxFiltros.Text = "Filtrar por";
                    Program.frmResultados.rbDeporte.Text = "Deporte";
                    Program.frmResultados.rbEquipo.Text = "Equipo";
                    Program.frmResultados.rbTodoslosFiltros.Text = "Todos los filtros";
                    Program.frmResultados.lblEvento1.Text = "Nombre del encuentro: ";
                    Program.frmResultados.lblDeporteEvento.Text = "Deporte del encuentro: ";
                    Program.frmResultados.lblfechaComienzo.Text = "Fecha de comienzo: ";
                    Program.frmResultados.lblFechaFin.Text = "Fecha de finalización: ";
                    Program.frmResultados.lblEquiposParticipando.Text = "Equipos en el encuentro: ";
                    Program.frmResultados.btnIncidencias.Text = "Incidencias";
                    Program.frmResultados.btnAlineacion.Text = "Alineacion";
                    Program.frmResultados.btnVolver.Text = "Volver";
                    Program.frmResultados.gboxResultados.Text = "Otro tipo de resultado";
                    Program.frmResultados.rbPuntos.Text = "Puntos";
                    Program.frmResultados.lstResultado.Columns.Clear();

                    ColumnHeader columna0 = new ColumnHeader();
                    columna0.Text = "Equipos";
                    columna0.TextAlign = HorizontalAlignment.Center;
                    columna0.Width = 83;
                    Program.frmResultados.lstResultado.Columns.Add(columna0);
                    ColumnHeader columna1 = new ColumnHeader();
                    columna1.Text = "Punots/Anotaciones";
                    columna1.TextAlign = HorizontalAlignment.Center;
                    columna1.Width = 150;
                    Program.frmResultados.lstResultado.Columns.Add(columna1);
                    ColumnHeader columna2 = new ColumnHeader();
                    columna2.Text = "Sets ganados";
                    columna2.TextAlign = HorizontalAlignment.Center;
                    columna2.Width = 100;
                    Program.frmResultados.lstResultado.Columns.Add(columna2);


                    #endregion

                    #region de frmIncidencias
                    Program.frmIncidencias.lblEquipo.Text = "Equipos: ";
                    Program.frmIncidencias.btnRefrescar.Text = "Refrescar";
                    Program.frmIncidencias.btnVolver.Text = "Volver";
                    Program.frmIncidencias.btnIncidencias.Text = "Mostrar incidencias";
                    Program.frmIncidencias.lstviewIncidencias.Columns.Clear();
                    ColumnHeader chIE0 = new ColumnHeader();
                    chIE0.Text = "Nombre";
                    chIE0.TextAlign = HorizontalAlignment.Center;
                    chIE0.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chIE0);
                    ColumnHeader chIE1 = new ColumnHeader();
                    chIE1.Text = "Apellido";
                    chIE1.TextAlign = HorizontalAlignment.Center;
                    chIE1.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chIE1);
                    ColumnHeader chIE2 = new ColumnHeader();
                    chIE2.Text = "Ocurrencia";
                    chIE2.TextAlign = HorizontalAlignment.Center;
                    chIE2.Width = 83;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chIE2);
                    ColumnHeader chIE3 = new ColumnHeader();
                    chIE3.Text = "Minuto";
                    chIE3.TextAlign = HorizontalAlignment.Center;
                    chIE3.Width = 50;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chIE3);
                    ColumnHeader chIE4 = new ColumnHeader();
                    chIE4.Text = "Puntos sumados";
                    chIE4.TextAlign = HorizontalAlignment.Center;
                    chIE4.Width = 240;
                    Program.frmIncidencias.lstviewIncidencias.Columns.Add(chIE4);

                    #endregion

                    #region de frmAlineacion
                    Program.frmAlineacion.lblEquipo.Text = "Equipos: ";
                    Program.frmAlineacion.btnRefrescar.Text = "Refrescar";
                    Program.frmAlineacion.btnVolver.Text = "Volver";
                    Program.frmAlineacion.btnVerAlineacion.Text = "Ver alineación";

                    Program.frmAlineacion.lstviewAlineacion.Columns.Clear();

                    ColumnHeader chAE0 = new ColumnHeader();
                    chAE0.Text = "Nombre";
                    chAE0.TextAlign = HorizontalAlignment.Center;
                    chAE0.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAE0);

                    ColumnHeader chAE1 = new ColumnHeader();
                    chAE1.Text = "Apellido";
                    chAE1.TextAlign = HorizontalAlignment.Center;
                    chAE1.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAE1);

                    ColumnHeader chAE2 = new ColumnHeader();
                    chAE2.Text = "Posición";
                    chAE2.TextAlign = HorizontalAlignment.Center;
                    chAE2.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAE2);

                    ColumnHeader chAE3 = new ColumnHeader();
                    chAE3.Text = "Equipo";
                    chAE3.TextAlign = HorizontalAlignment.Center;
                    chAE3.Width = 83;
                    Program.frmAlineacion.lstviewAlineacion.Columns.Add(chAE3);

                    #endregion
                    break;
            }
        }
            public static string cambiarIdiomaBotonAvisame(string textoActual)
            {
                string texto = null;
                if (Program.frmConfiguracion.cmboxIdiomas.SelectedItem.ToString().Equals("Español"))
                {
                    if (textoActual.Equals("Notify"))
                    {
                        texto = "Avísame";
                    }
                    else
                    { if (textoActual.Equals("Not notify")) {
                        texto = "No me avises";

                    }
                }
                }
                else
                {
                    if (textoActual.Equals("Avísame"))
                    {
                        texto = "Notify";
                    }
                    else
                    {
                    if(textoActual.Equals("No me avises"))
                    {
                        texto = "Not notify";
                    }
                }
                }
                return texto;
            }
    }
}
