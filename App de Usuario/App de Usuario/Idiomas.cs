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
                    break;
            }
        }
    }
}
