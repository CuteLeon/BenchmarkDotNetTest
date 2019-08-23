using System;

namespace BenchmarkDotNetTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I am Target program.");
            var testText = "the shortest English sentence containing 26 letters";

            var md5 = HashHelper.CalcMD5(testText);
            Console.WriteLine(md5);

            var sha1 = HashHelper.CalcSHA1(testText);
            Console.WriteLine(sha1);

            var sha256 = HashHelper.CalcSHA256(testText);
            Console.WriteLine(sha256);

            var sha384 = HashHelper.CalcSHA384(testText);
            Console.WriteLine(sha384);

            var sha512 = HashHelper.CalcSHA512(testText);
            Console.WriteLine(sha512);

            Console.ReadLine();
        }
    }
}
