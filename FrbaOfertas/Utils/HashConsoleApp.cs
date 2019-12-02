using System;
using System.Text;
using System.Security.Cryptography;

//Funciones para Hashear a SHA256 una contraseña dada

namespace FrbaOfertas.Utils
{
    class HashConsoleApp
    {
         
        static byte[] ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                return bytes;
            }
        }

    }

}