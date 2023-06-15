using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.IO.Pipes;

namespace prosek.application
{
    public class Hash
    {

        public static string SHA256CheckSum(string filePath)
        {
            using (SHA256 SHA256 = System.Security.Cryptography.SHA256.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return BitConverter.ToString(SHA256.ComputeHash(fileStream)).Replace("-", String.Empty);
            }
        }
    }
}
