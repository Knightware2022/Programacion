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
                    #region "idioma de frmPrincipal"
                    Program.frmPrincipal.btnDeportes.Text = "Sports";
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
                    Program.frmLogin.cmboxCambiarIdiomaII.Text = "Ingles";//"actualizo" todos los cmbox de idiomas con el mismo
                    Program.frmLogin.cmboxIdioma.Text = "Ingles";   
                    Program.frmConfiguracion.cmboxIdiomas.Text = "Ingles";
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
                    Program.frmConfiguracion.btnCambiarUsuario.Text = "Change";
                    Program.frmConfiguracion.btnCambiarCorreo.Text = "Change";
                    Program.frmConfiguracion.btnCambiarContrasenia.Text = "Change";
                    Program.frmConfiguracion.btnCambiarAvatar.Text = "Change avatar";
                    Program.frmConfiguracion.btnAplicarCambios.Text = "Apply changes";
                    #endregion
                    #region de frmDeportesFavoritos
                    Program.frmDeportesFavoritos.lblDeportesFavoritos.Text = "Favorite sports: ";
                    Program.frmDeportesFavoritos.btnEliminarFavoritos.Text = "Delete";
                    Program.frmDeportesFavoritos.btnRefrescar.Text = "Refresh";
                    Program.frmDeportesFavoritos.btnVolver.Text = "Return";
                    #endregion
                    #region de frmEventosProgramados
                    Program.frmEventosProgramados.lblDeporte.Text = "Sport: ";
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filter";
                    #endregion
                    break;
                case "Español" :
                    #region "de frmPrincipal"
                    Program.frmPrincipal.btnDeportes.Text = "Deportes";
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
                    Program.frmLogin.cmboxCambiarIdiomaII.Text = "Español";//"actualizo" todos los cmbox de idiomas con el mismo
                    Program.frmLogin.cmboxIdioma.Text = "Español";
                    Program.frmConfiguracion.cmboxIdiomas.Text = "Español";
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
                    Program.frmConfiguracion.btnCambiarUsuario.Text = "Cambiar";
                    Program.frmConfiguracion.btnCambiarCorreo.Text = "Cambiar";
                    Program.frmConfiguracion.btnCambiarContrasenia.Text = "Cambiar";
                    Program.frmConfiguracion.btnCambiarAvatar.Text = "Cambiar avatar";
                    Program.frmConfiguracion.btnAplicarCambios.Text = "Aplicar cambios";
                    #endregion
                    #region de frmDeportesFavoritos
                    Program.frmDeportesFavoritos.lblDeportesFavoritos.Text = "Deportes favoritos: ";
                    Program.frmDeportesFavoritos.btnEliminarFavoritos.Text = "Eliminar de favoritos";
                    Program.frmDeportesFavoritos.btnRefrescar.Text = "Refrescar";
                    Program.frmDeportesFavoritos.btnVolver.Text = "Cerrar";
                    #endregion
                    #region de frmEventosProgramados
                    Program.frmEventosProgramados.lblDeporte.Text = "Deportes: ";
                    Program.frmEventosProgramados.btnFiltrar.Text = "Filtrar";
                    #endregion
                    break;
            }
        }
        //comentario prueba margtin
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
