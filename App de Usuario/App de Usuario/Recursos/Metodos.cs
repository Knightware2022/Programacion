using App_de_Usuario.Recursos;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace App_de_Usuario
{
    public class Metodos
    {
        #region "serializacion"
        public static string Serializar(List<string> datosASerializar) //devuelve un string con la lista serializada
        {
            return JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented); //Serializa la cadena devolucion
        }
        public static string SerializeJsonFile(List<Usuario> datosASerializar)
        {
            return JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented);
        }

        #endregion
        #region "deserializacion"
        public static List<string> DeserealizeJsonFilePublicidad(string jsonSerializado)
        {
            return JsonConvert.DeserializeObject<List<string>>(jsonSerializado);
        }
        public static List<Usuario> DeserealizeJsonFileUsuario(string jsonSerializado)
        {
            return JsonConvert.DeserializeObject<List<Usuario>>(jsonSerializado);
        }
        public static string[] DeserealizeJsonFile(string jsonSerializado)
        {
            return JsonConvert.DeserializeObject<string[]>(jsonSerializado);
        }
        #endregion
    }
}