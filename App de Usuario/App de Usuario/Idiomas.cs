using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Program.frmEventosProgramados.lblDeporte.Text = "Sport: ";
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filter";

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
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filtrar";
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
