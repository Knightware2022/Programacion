using System;
namespace App_de_Usuario.Recursos { 

public class ApiPublicidad
{
   
    public static string obtenerPublicidad()
    {//devuelve un String con el link deserealizado
        string url;
        List<string> lista = Metodos.DeserealizeJsonFilePublicidad(respuesta);//respuesta será un string serializado de la capa logica
        url = lista[0];
        return url;
    }
}
}

