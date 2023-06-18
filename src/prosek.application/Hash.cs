using System.Security.Cryptography;

namespace prosek.application
{
    public class Hash
    {
        /// <summary>
        /// Get SHA265 Hash from File.
        /// </summary>
        /// <param name="filePath">File Path.</param>
        public static string SHA256CheckSum(string filePath)
        {
            using (SHA256 SHA256 = System.Security.Cryptography.SHA256.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return BitConverter
                        .ToString(SHA256.ComputeHash(fileStream))
                        .Replace("-", String.Empty);
            }
        }
    }
}
