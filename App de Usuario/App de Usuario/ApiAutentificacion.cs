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
            _usuario.nombre = n;
            _usuario.rol = 2;
            _usuario.correo = correo;
            _usuario.contrasenia = contra;
            respuesta = Logica.AltaUsuarioVIP(_usuario);
            _usuario = null;
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
