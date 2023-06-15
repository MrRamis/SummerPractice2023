using System;
using System.Security.Cryptography;
using System.Text;

namespace SummerPractice2023.Models
{
    internal class Hash
    {
        public static string? hashPassword(string password)
        {
            MD5 mD5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = mD5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (byte b2 in hash)
                sb.Append(b2.ToString("X2"));
            return Convert.ToString(sb);
        }
    }
}
