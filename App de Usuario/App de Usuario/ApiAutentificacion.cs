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
        public byte olvideContrasenia(string correo) {
            byte devolver = 0;
            Random r = new Random();
            string contra = null;
            Encriptacion en = new Encriptacion();
            int x, y;
            usuario.correo = correo;
            switch (Logica.averiguarCorreo(usuario))
            {
                case 0:
                    string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz@5#$%&##$/&)( ";
                    for (int i = 0; i < 8; i++)
                    {
                        x = r.Next((abecedario.Length - 1));
                        //       y = x+ 1;
                        contra += abecedario.Substring(x, 1);
                    }
                    contra += r.Next(9999);
                    usuario.contrasenia = en.encriptar(contra);
                    switch (Logica.modificarContraseña(usuario.nombre, usuario.contrasenia))
                    {
                        case 0:
                            Mensajeria.sendCorreo(usuario.correo, contra);
                            devolver = 0;
                            break;
                        case 1:
                            devolver = 1;
                            break;
                        case 2:
                            devolver = 2;

                            break;
                    }
                    break;
                case 1:
                    devolver = 0;
                    break;
                case 2:
                    devolver = 2;
                   
                    break;
                case 3:
                    devolver = 3;
                    break;

            }
            return devolver;
        }
    }
}
