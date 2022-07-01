using System;
using Apis.Recursos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace App_de_Usuario.Recursos { 
public class ApiAutentificacion
{

        static void Main(string[] args)
        {
            List<string> Datos = crearIngreso();
            string jsonFile = JsonConvert.SerializeObject(Datos.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, jsonFile);
            // mandarDatosALogica();
            // recibirDatosdeLogicaInicioSesion();
            registrarUsuario();
            recibirDatosdeLogicaRegistro();
            Console.ReadKey();  //para que la terminal no se cierre
        }

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
        public static List<string> crearIngreso() //para suponer los datos que el usuario ingresa(pruebas)
        {
            List<string> lista = new List<string>
                            {
                                "Batman",
                                "QWE3R4qead",
                                "QWE3Rqead",
                                "msdfe@gmail.com"
                            };

            return lista;
        }

        //Leerá los datos ingresados por el usuario para iniciar sesion, crea un objeto de tipo usuario y serializa
        public static string mandarDatosALogica()
        {
            string datosdelUsuario = GetJSonFromFile(_path);
            string[] datos = DeserealizeJsonFile(datosdelUsuario);//obtengo en un array los datos ingresados por el usuario
            string nombre = datos[0];
            string contrasenia = datos[1];
            string email = datos[2];
            List<Usuario> usuario = crearUsuario(nombre, contrasenia, email);
            return Metodos.SerializeJsonFile(usuario);
        }

        //Se encarga de leer el json con la respuesta de la capa logica y "traducirla"
        public static string recibirDatosdeLogicaInicioSesion()
        {
            string respuestaaUsuario;
            string devolucion;
            string[] r = Metodos.DeserealizeJsonFile(respuestadeLogica);//respuestaLogica es un string serializado de la capa logica
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
        public static string registrarUsuario()
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
        public static string[] recibirDatosdeLogicaRegistro()
        {
            string respuestAaUsuario;
            string[] r = DeserealizeJsonFile(respuestadeLogica);
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
            respuestAaUsuario = JsonConvert.SerializeObject(respuestAaUsuario.ToArray(), Formatting.Indented);//serializo la respuesta.
        return respuestAaUsuario;
        }
}
}


