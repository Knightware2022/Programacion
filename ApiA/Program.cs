using ApiA.Recursos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ApiA
{
    internal class Program
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
        public static String _path = @"C:\Users\User\Desktop\Apia\Autentificacion\DatosUsuario";
        public static String _pathEnviarLogica = @"C:\Users\User\Desktop\Apia\Respuestas de la logica\respuestaCapaLogicaAutenticacion";
        public static String _pathRecibirLogica = @"C:\Users\User\Desktop\Apia\Respuestas de la logica\respuestaCapaLogica";

        #region "Serializacion (se le pasa una lista de tipo String con los datos para crear el json)"
        public static void SerializeJsonFile(List<Usuario> datosASerializar, string _path)
        {
            string jsonFile = JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented); //Serializa la cadena devolucion
            File.WriteAllText(_path, jsonFile); //crea un archivo con esos datos en formato JSON
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
        public static List<Usuario> registrarUsuario(string nombre, string contrasenia,string confirContrasenia, string email)
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
        #endregion

        #region "Deserializacion"
        public static string GetJSonFromFile(string _path)
        { //devuelve un string con el json serializado de la capa logica
            string jsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            return jsonFromFile;
        }
        public static List<Usuario> DeserealizeJsonFileUsuario(string jsonFromFile)
       {
            //Console.Write(jsonFromFile);//muestra los datos en la consola
              return JsonConvert.DeserializeObject<List<Usuario>>(jsonFromFile);//se le puede pasar como argumento el formato
        }
        public static string[] DeserealizeJsonFile(string jsonFromFile)
        {
            //Console.Write(jsonFromFile);//muestra los datos en la consola
            return JsonConvert.DeserializeObject<string[]>(jsonFromFile);//se le puede pasar como argumento el formato
        }

        #endregion
       
        //Leerá los datos ingresados por el usuario para iniciar sesion, crea un objeto de tipo usuario y crea un json
        public static void mandarDatosALogica() {
            string datosdelUsuario = GetJSonFromFile(_path);
            string[] datos = DeserealizeJsonFile(datosdelUsuario);//obtengo en un array los datos ingresados por el usuario
            string nombre = datos[0];
            string contrasenia = datos[1];
            string email = datos[2];
            List<Usuario> usuario = crearUsuario(nombre, contrasenia, email);
            SerializeJsonFile(usuario, _pathEnviarLogica);
            Console.WriteLine("UsuarioSerializado");
        }
    
        //Se encarga de leer el json con la respuesta de la capa logica y "traducirla"
        public static void recibirDatosdeLogicaInicioSesion() {
            string respuestaaUsuario;
            string devolucion;
            string respuestadeLogica = GetJSonFromFile(_pathRecibirLogica);
            string[] r = DeserealizeJsonFile(respuestadeLogica);
            if (r[0].Equals("0")) {
                respuestaaUsuario = "true"; //logro loguearse
            }
            else
            {
                if (r[0].Equals("1"))
                {
                    respuestaaUsuario = "Usuario no existe";
                }
                else {
                    respuestaaUsuario = "Usuario o contraseña invalidos";
                }
            }
            Console.WriteLine(respuestaaUsuario);
            devolucion = JsonConvert.SerializeObject(respuestaaUsuario.ToArray(), Formatting.Indented);//serializo la respuesta.
            File.WriteAllText(_path, devolucion);//lo "guardo" en el path donde se comunica la app de usuario
        }
        public static void registrarUsuario() {
            string error = null;
            string datosdelUsuario = GetJSonFromFile(_path);
            string[] datos = DeserealizeJsonFile(datosdelUsuario);//obtengo en un array los datos ingresados por el usuario
            string nombre = datos[0];
            string contrasenia = datos[1];
            string confirC = datos[2];
            string email = datos[3];
            if (contrasenia.Equals(confirC)) {
                if (email.Contains("@") && email.Contains(".") && email.Length > 6)//7 es la cantidad de caracteres de direccion de correo mas corto: a@d.com
                {
                    List<Usuario> RegistroUsuario = registrarUsuario(nombre, contrasenia, confirC, email);
                    SerializeJsonFile(RegistroUsuario, _pathEnviarLogica);
                    Console.WriteLine("UsuarioSerializado");
                }
                else {
                    error = "Direccion de correo invalida";
                }
            }
            else {
                error = "Las contrasenias no coinciden";
            }
            if (error != null)
            {
                error = JsonConvert.SerializeObject(error, Formatting.Indented);//serializo la respuesta.
                File.WriteAllText(_path, error);
            }
            Console.WriteLine("usuario registrado");

        }
        public static void recibirDatosdeLogicaRegistro()
        {
            string respuestAaUsuario;
            string respuestadeLogica = GetJSonFromFile(_pathRecibirLogica);
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
            Console.WriteLine(respuestAaUsuario);
            respuestAaUsuario = JsonConvert.SerializeObject(respuestAaUsuario.ToArray(), Formatting.Indented);//serializo la respuesta.
            File.WriteAllText(_path, respuestAaUsuario);//lo "guardo" en el path donde se comunica la app de usuario
        }
    }
}
