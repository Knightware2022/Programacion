using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class ApiAutentificacion
    {
        protected Usuario _usuario;

        public ApiAutentificacion() {
            _usuario = new Usuario();
        }
        public Usuario usuario{
            get{ return _usuario; }
            set { _usuario = value;}       
        }

        public byte Registrarse(string n, string contra, string correo) {
            byte respuesta;
            bool bandera = true;
            Random r = new Random();
            int random = 1;
            _usuario.nombre = n;
            _usuario.rol = 2;
            _usuario.correo = correo;
            _usuario.contrasenia = contra;
            while (bandera == true) {
                random = r.Next();
                switch (Logica.BuscarID(random)) {
                    case 0:
                        break;
                    case 1:
                    case 2:
                        return 2;
                        break;             
                    case 3:
                        bandera = false;
                        break;
                }
            }
            _usuario.id = random;
            _usuario.mesesSuscritos = 0;
            respuesta = Logica.AltaUsuarioVIP(_usuario);
            return respuesta;
        }
        public byte iniciarSesion(string nombre, string contraseña) {
            byte devolver = 0;
            Encriptacion encriptacion = new Encriptacion();
            _usuario.nombre = nombre;
            _usuario.contrasenia = encriptacion.encriptar(contraseña);
            devolver = Logica.BuscandoUsuario(_usuario);
            _usuario = null;
            return devolver;
        }
    }
}
