using System;

namespace App_de_Usuario.Apis { 
public class Metodos
{
    public static String serializar(List<string> datosASerializar) { //devuelve un string con la lista serializada
        string jsonFile = JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented); //Serializa la cadena devolucion
    }
    public static void SerializeJsonFile(List<Usuario> datosASerializar)
    {
        string jsonFile = JsonConvert.SerializeObject(datosASerializar.ToArray(), Formatting.Indented); //Serializa la cadena devolucion
        //File.WriteAllText(_path, jsonFile); //crea un archivo con esos datos en formato JSON
    }
    public static List<string> DeserealizeJsonFilePublicidad(string jsonSerializado)
    {
        //Console.Write(jsonFromFile);//muestra los datos en la consola
        return JsonConvert.DeserializeObject<List<string>>(jsonFromFile);//se le puede pasar como argumento el formato
    }
    public static List<Usuario> DeserealizeJsonFileUsuario(string jsonSerializado)
    {
        //Console.Write(jsonFromFile);//muestra los datos en la consola
        return JsonConvert.DeserializeObject<List<Usuario>>(jsonFromFile);//se le puede pasar como argumento el formato
    }
    public static string[] DeserealizeJsonFile(string jsonSerializado)
    {
        //Console.Write(jsonFromFile);//muestra los datos en la consola
        return JsonConvert.DeserializeObject<string[]>(jsonFromFile);//se le puede pasar como argumento el formato
    }

    }
}
