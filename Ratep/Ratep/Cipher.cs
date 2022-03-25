using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratep
{
   public class Cipher
    {
        private static List<byte> key = new List<byte>()
        {
         1, 2, 3, 4, 2, 1, 3, 5, 2, 2
        };
        public static string Encrypt(string m)
        {
            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < m.Length; i++)
            {
               result.Append((char)(m[i] ^ key[i % key.Count()]));
               
            }
            return result.ToString();
        }
    }
}
