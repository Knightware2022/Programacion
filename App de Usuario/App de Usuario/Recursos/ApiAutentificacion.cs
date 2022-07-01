using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace App_de_Usuario.Recursos { 
public class ApiAutentificacion
{
        public static List<Usuario> crearUsuario(string nombre, string contrasenia, string email)
        {
            List<Usuario> lista = new List<Usuario>
                            {
                                new Usuario{
                                    nombreUsuario = nombre,
                                    contrasenia = contrasenia,
                                    correo = email,
                                }
                            };

            return lista;
        }
        public static List<Usuario> registrarUsuario(string nombre, string contrasenia, string confirContrasenia, string email)
        {
            List<Usuario> lista = new List<Usuario>
                            {
                                new Usuario{
                                    nombreUsuario = nombre,
                                    contrasenia = contrasenia,
                                    confContrasenia=confirContrasenia,
                                    correo = email,
                                }
                            };

            return lista;
        }
        public static List<string> crearIngreso(string nombre, string contrasenia, string correo) //para suponer los datos que el usuario ingresa(pruebas)
        {
            List<string> lista = new List<string>
                            {
                                nombre,
                                correo,
                                contrasenia,
                                "msdfe@gmail.com"
                            };

            return lista;
        }

        //Leerá los datos ingresados por el usuario para iniciar sesion, crea un objeto de tipo usuario y serializa
        public static string mandarDatosALogica(string datosdelUsuario)
        {
            string[] datos = Metodos.DeserealizeJsonFile(datosdelUsuario);
            string nombre = datos[0];
            string contrasenia = datos[1];
            string email = datos[2];
            List<Usuario> usuario = crearUsuario(nombre, contrasenia, email);
            return Metodos.SerializeJsonFile(usuario);//devuelve un objeto de tipo usuario serializado
        }

        //Se encarga de leer la respuesta de la capa logica y "traducirla"
        public static string recibirDatosdeLogicaInicioSesion(string respuestadeLogica)
        {
            string respuestaaUsuario;
            string devolucion;
            List<string> r = Metodos.DeserealizeJsonFilePublicidad(respuestadeLogica);//respuestaLogica es un string serializado de la capa logica
            if (r[0].Equals("0"))
            {
                respuestaaUsuario = "true"; //logro loguearse
            }
            else
            {
                if (r[0].Equals("1"))
                {
                    respuestaaUsuario = "Usuario no existe";
                }
                else
                {
                    respuestaaUsuario = "Usuario o contraseña invalidos";
                }
            }
          //Console.WriteLine(respuestaaUsuario);
            devolucion = JsonConvert.SerializeObject(respuestaaUsuario.ToArray(), Formatting.Indented);//serializo la respuesta.
        return devolucion;
        }
        public static string registrarUsuario(string datosdelUsuario)
        {
            string error = null;
            string[] datos = Metodos.DeserealizeJsonFile(datosdelUsuario);//obtengo en un array los datos ingresados por el usuario
            string nombre = datos[0];
            string contrasenia = datos[1];
            string confirC = datos[2];
            string email = datos[3];
            if (contrasenia.Equals(confirC))
            {
                if (email.Contains("@") && email.Contains(".") && email.Length > 6)//7 es la cantidad de caracteres de direccion de correo mas corto: a@d.com
                {
                    List<Usuario> RegistroUsuario = registrarUsuario(nombre, contrasenia, confirC, email);
                    Metodos.SerializeJsonFile(RegistroUsuario);
                }
                else
                {
                    error = "Direccion de correo invalida";
                }
            }
            else
            {
                error = "Las contrasenias no coinciden";
            }
             return error = JsonConvert.SerializeObject(error, Formatting.Indented);//serializo la respuesta.       
        }
        public static string[] recibirDatosdeLogicaRegistro(string respuestadeLogica)
        {
            string respuestAaUsuario;
            string[] r = Metodos.DeserealizeJsonFile(respuestadeLogica);
            if (r[0].Equals("0"))
            {
                respuestAaUsuario = "true"; //logro registrarse
            }
            else
            {
                if (r[0].Equals("1"))
                {
                    respuestAaUsuario = "Estos datos ya estan siendo usados";
                }
                else
                {
                    respuestAaUsuario = "Un error ocurrio";
                }
            }
            r[0] = JsonConvert.SerializeObject(respuestAaUsuario.ToString(), Formatting.Indented);//serializo la respuesta.
        return r;
        }
}
}


