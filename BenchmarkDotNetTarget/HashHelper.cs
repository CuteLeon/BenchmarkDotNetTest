using System.Security.Cryptography;
using System.Text;

namespace BenchmarkDotNetTarget
{
    public static class HashHelper
    {
        public static string CalcMD5(string text)
        {
            using var hashAlgorithm = MD5.Create();
            return GetString(CalcHash(text, hashAlgorithm));
        }

        public static string CalcSHA1(string text)
        {
            using var hashAlgorithm = SHA1.Create();
            return GetString(CalcHash(text, hashAlgorithm));
        }

        public static string CalcSHA256(string text)
        {
            using var hashAlgorithm = SHA256.Create();
            return GetString(CalcHash(text, hashAlgorithm));
        }

        public static string CalcSHA384(string text)
        {
            using var hashAlgorithm = SHA384.Create();
            return GetString(CalcHash(text, hashAlgorithm));
        }

        public static string CalcSHA512(string text)
        {
            using var hashAlgorithm = SHA512.Create();
            return GetString(CalcHash(text, hashAlgorithm));
        }

        private static byte[] CalcHash(string text, HashAlgorithm hashAlgorithm)
            => hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(text));

        private static string GetString(byte[] values)
        {
            int valueCount = values.Length;
            int charCount = values.Length * 2;
            int charIndex = 0;
            char[] chars = new char[charCount];

            for (int valueIndex = 0; valueIndex < valueCount; valueIndex++)
            {
                byte currentValue = values[valueIndex];
                chars[charIndex++] = GetHexValue(currentValue / 16);
                chars[charIndex++] = GetHexValue(currentValue % 16);
            }

            return new string(chars);
        }

        private static char GetHexValue(int i)
        {
            return (char)(i < 10 ? i + 48 : i + 55);
        }
    }
}
