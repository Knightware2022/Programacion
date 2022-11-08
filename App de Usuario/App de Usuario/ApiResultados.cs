using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public static class ApiResultados
    {
        public static Usuario usuario = new Usuario();

        public static byte obtenerDeportesFavoritos(List<string> deportesFavo) {
            byte respuesta = 0;

            switch (Program.apiA.datosUsuario(Login.nombreUsuario, ApiResultados.usuario)) {
                case 0:
                    switch (Logica.averiguarDeportesFavoritos(ApiResultados.usuario.id, deportesFavo)) {
                        case 0:
                            break;
                        default:
                            return respuesta = 2;
                            break;
                    }
                    break;
                default:
                    return 2;
                    break;
            }


            return respuesta;
        }
        public static byte EliminarDeportesFavoritos(string nombreDepo)
        {
            byte respuesta = 0;

            switch (Program.apiA.datosUsuario(Login.nombreUsuario, ApiResultados.usuario))
            {
                case 0:
                    switch (Logica.EliminarDeporteFavorito(nombreDepo, ApiResultados.usuario.id))
                    {
                        case 0:
                            break;
                        default:
                            return respuesta = 2;
                            break;
                    }
                    break;
                default:
                    return 2;
                    break;
            }


            return respuesta;
        }
        public static byte AgregarDeportesFavoritos(string nombreDepo)
        {
            byte respuesta = 0;

            switch (Program.apiA.datosUsuario(Login.nombreUsuario, ApiResultados.usuario))
            {
                case 0:
                    switch (Logica.AgregarDeporteFavorito(nombreDepo, ApiResultados.usuario.id))
                    {
                        case 0:
                            break;
                        default:
                            return respuesta = 2;
                            break;
                    }
                    break;
                default:
                    return 2;
                    break;
            }


            return respuesta;
        }
        public static byte obtenerDeportesenSistema(List<string> deportes)
        {
          byte respuesta = 0;

            switch (Logica.nombresDeportes(deportes))

            {

                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
                    }


            return respuesta;
        }

    }
}
