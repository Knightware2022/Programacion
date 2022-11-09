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
        public static byte EventosProgramados(List<string> Eventos, string deporte)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosConNombre(Eventos, deporte))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte datosEventosProgramados(EncuentrosColectivos Eventos, List<string> deportes)
        {
            byte respuesta = 0;

            switch (Logica.DatosEncuentrosColectivos(Eventos, deportes))
            {
                case 0:
                    break;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                case 5:
                    return 5;
                    break;
            }


            return respuesta;
        }
        public static byte JugadoresDeEventos(string nombre, string categoria,int idEncuentro ,List<string> jugadores)
        {
            byte respuesta = 0;

            switch (Logica.mostrarJugadoresDeEquipo(nombre, categoria, idEncuentro, jugadores))
            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte SuscribirseAEvento(int idEncuentro, int idDeporte, string usuario)
        {
            byte respuesta = 0;

            switch (Logica.mostrarJugadoresDeEquipo(usuario, idEncuentro, idDeporte))
            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
            }


            return respuesta;
        }
        public static byte EventosProgramadosconEquipo(List<string> Eventos, string nombre, string categoria)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosConEquipo(Eventos, nombre, categoria))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte obtenerEquiposEnSistema(List<string> equipos)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEquipos(equipos))

            {

                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte EventosProgramadosconTodosLosFiltros(List<string> Eventos, string nombre, string categoria, string deporte) { 
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosConTodosLosFiltros(Eventos, nombre, categoria, deporte))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte EventosJugadosxJugar(List<string> Eventos, string deporte)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosJugados(Eventos, deporte))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte EventosJugadosxJugarconEquipo(List<string> Eventos, string nombre, string categoria)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosJugadosconEquipo(Eventos, nombre, categoria))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte EventosJugadosxJugarConTodosLosFiltros(List<string> Eventos, string nombre, string categoria, string deporte)
        {
            byte respuesta = 0;

            switch (Logica.cargarNombreEncuentrosJugadosConTodosLosFiltros(Eventos, nombre, categoria, deporte))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarEquiposAlineacion(int idEncuentro, List<string> Eventos)
        {
            byte respuesta = 0;

            switch (Logica.EquiposEncuentrosColectivos(idEncuentro, Eventos))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarAlineacion(List<string> jNombre, List<string> jApellido, List<string> jPosicion, List<string> jEquipo, int idEncuentro, string nombreEquipo, string categoriaEquipo, EncuentrosColectivos c)
        {
            byte respuesta = 0;

            switch (Logica.mostrarAlineaciondeEquipoYsuLogo(jNombre, jApellido, jPosicion, jEquipo, idEncuentro, nombreEquipo, categoriaEquipo, c))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarIncidencias(List<string> jNombre, List<string> jApellido, List<string> jOcurrencia, List<string> jEquipo, int idEncuentro, string nombreEquipo, string categoriaEquipo, EncuentrosColectivos c, List<string> puntos, List<string> minuto)
        {
            byte respuesta = 0;

            switch (Logica.mostrarIncidenciasporEquipoyLogo(jNombre, jApellido, jOcurrencia, jEquipo, idEncuentro, nombreEquipo, categoriaEquipo, c, puntos, minuto))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarResultadoPuntos(List<string> jNombre, List<string> puntuacion, List<string> logos, int idEncuentro)
        {
            byte respuesta = 0;

            switch (Logica.mostrarResultadoPuntos(jNombre, puntuacion,logos, idEncuentro))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarResultadosSets(List<string> jNombre, List<string> puntuacion, List<string> logos, int idEncuentro)
        {
            byte respuesta = 0;

            switch (Logica.mostrarResultadoSets(jNombre, puntuacion, logos, idEncuentro))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }
        public static byte ConsultarResultadosRankings(List<string> jNombre, List<string> puntuacion, List<string> logos, int idEncuentro)
        {
            byte respuesta = 0;

            switch (Logica.mostrarResultadoRankings(jNombre, puntuacion, logos, idEncuentro))

            {
                case 0:
                    break;
                default:
                    return respuesta = 2;
                    break;
            }


            return respuesta;
        }

        public static byte NotificacionEvento(string usuario, List<string> eventos, List<DateTime> fechaComienzo) {
            byte devolver = 0;
            switch (Logica.SistemaNotificaciones(eventos, fechaComienzo, usuario)) {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
            }
            return devolver;
        }
    }
}
