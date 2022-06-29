using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiPublicidad
{
    class Program
    {
        static void Main(string[] args)
        {
            string publicidad = obtenerPublicidad();
            Console.WriteLine(publicidad);
            Console.ReadKey();
        }
        public static string _path = @"C:\Users\User\Desktop\ApiA\apiPublicidad\Respuestas de la logica\respuestaCapaLogica";
        #region "Serializacion (se le pasa una lista de tipo String con los datos para crear el json)"
        public static void SerializeJsonFile(List<string> datosASerializar, string _path)
        {
            string jsonFile = JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented); //Serializa la cadena devolucion
            File.WriteAllText(_path, jsonFile); //crea un archivo con esos datos en formato JSON
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
        public static List<string> DeserealizeJsonFilePublicidad(string jsonFromFile)
        {
            //Console.Write(jsonFromFile);//muestra los datos en la consola
            return JsonConvert.DeserializeObject<List<string>>(jsonFromFile);//se le puede pasar como argumento el formato
        }
        #endregion

        public static string obtenerPublicidad() {//devuelve un String con el link deserealizado
            string url;
            string respuesta = GetJSonFromFile(_path);//deserealizo el JSON que nos responde la capa logica con la url
            List<string> lista = DeserealizeJsonFilePublicidad(respuesta);
            url = lista[0];
            return url;
        }
    }
}
