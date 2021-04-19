using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Text;

namespace FinalService
{
    public static class Secrecy
    {

        public static string HashPawword(string password)
        {
            SHA1 alogorith = SHA1.Create();

            byte[] byteArray = null;
            byteArray = alogorith.ComputeHash(Encoding.Default.GetBytes(password));
            string hasshedPassword = "";
            for(int i = 0; i > byteArray.Length -1; i++)
            {
                hasshedPassword += byteArray[i].ToString("x2");
            }
            return hasshedPassword;
        }
    }
}