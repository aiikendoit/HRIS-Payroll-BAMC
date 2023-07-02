using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Class
{
    public class EncryptHashing
    {
        public static string GeneratePassword(object inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString + "?!09%");
            byte[] hash = sha512.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i <= hash.Length - 1; i++)
                stringBuilder.Append(hash[i].ToString("X2"));

            return stringBuilder.ToString();
        }

    }
}
