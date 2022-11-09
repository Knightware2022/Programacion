using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Collections;

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
            _usuario.rol = 1;
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
            _usuario.mesesSuscritos = 1;
            respuesta = Logica.AltaUsuarioVIP(_usuario);
            return respuesta;
        }
        public byte iniciarSesion(string nombre, string contraseña) {
            byte devolver = 0;
            Encriptacion encriptacion = new Encriptacion();
            _usuario.nombre = nombre;
            _usuario.contrasenia = encriptacion.encriptar(contraseña);

            devolver = Logica.BuscandoUsuario(_usuario);
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
        public byte cambiarContrasenia(string nombreUsuario, string contraNueva, string confirmar) {
            byte devolver = 0;
            Encriptacion en = new Encriptacion();
            if (contraNueva == confirmar)
            {
                contraNueva = en.encriptar(contraNueva);
                switch (Logica.modificarContraseña(nombreUsuario, contraNueva)) {
                    case 0:
                        devolver = 0;
                        break;
                    case 1:
                        devolver = 1;
                        break;
                    case 2:
                        devolver = 2;
                        break;
                }
            }
            else {
                devolver = 3;  //contraseñas no coinciden
            }

            return devolver;
        }
        public string correo(string nombre) {
            string correo = null;
            _usuario.nombre = nombre;
            switch (Logica.BuscandoDatosUsuario(_usuario)) {
                case 0:
                    correo = _usuario.correo;
                    break;
                default:
                    correo = "Error";
                    break;
            }
            return correo;
        }
        public byte entrarComoGuest(List<string> macs) {    
            byte devolver = 0;
            int idUsuario;
            ArrayList dirmac = obtenerDirMAC();      
            string mac;
            string nombreAutogen;
            bool bandera = true;
            Random r = new Random();
            mac = dirmac[0].ToString();
            switch (Logica.buscandoMAC(mac)) {
                case 0: //ya se ingreso alguna vez con esta mac
                    macs.Add(mac);
                    return 0;
                    break;
                case 1:
                case 2:
                    return 2;
                    break;
                case 3: //si no se tiene registro de esta mac...
                    int random = 1;
                    while (bandera == true)
                    {
                        random = r.Next();
                        switch (Logica.BuscarID(random))
                        {
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
                    idUsuario = random;
                    nombreAutogen = "Guest-" + idUsuario;
                    mac = dirmac[0].ToString();
                    macs.Add(mac);
                    devolver = Logica.crearUsuarioGuest(idUsuario, nombreAutogen, mac);
                    break;

            }
            return devolver;
        }
        public ArrayList obtenerDirMAC() {
            ArrayList direccionesMAC = new ArrayList();
            NetworkInterface[] adaptadorRed = null;
            adaptadorRed = NetworkInterface.GetAllNetworkInterfaces();
            if (adaptadorRed != null && adaptadorRed.Length > 0) {//si tiene interfaces de red
                foreach (NetworkInterface interfaces in adaptadorRed) {
                    var direccion = interfaces.GetPhysicalAddress();
                    byte[] bytes = direccion.GetAddressBytes();
                    string mac = string.Empty;
                    for (int i = 0; i < bytes.Length; i++) {
                        mac = mac + bytes[i].ToString("x2");
                        if (i != bytes.Length - 1 ) {
                            mac = mac + "-";
                        }
                       
                    }
                    direccionesMAC.Add(mac);
                }
            }
            return direccionesMAC;
        }

        public byte datosUsuario(string nombre, Usuario u) {
            byte devolver = 0;
            u.nombre = nombre;
            switch (Logica.BuscandoDatosUsuario(u)) {
                case 0:
                    break;
                case 1:
                    devolver = 1;
                    break;
                case 2:
                    devolver = 2;
                    break;
            }
            return devolver;

        }
    }
}
