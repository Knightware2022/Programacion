using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class Encriptacion
    {
        public string encriptar(string mensajeAencriptar) {
            string hash = "codificando hash xd";//con este mensaje va a "hashear", debe ser fijo
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensajeAencriptar);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0 ,data.Length);

            return Convert.ToBase64String(resultado);
        }

        public string desencriptar(string mensajeEncriptado)
        {
            string hash = "codificando hash xd";
            byte[] data = Convert.FromBase64String(mensajeEncriptado);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}