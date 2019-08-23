using System;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I am Test program.");

            Summary summary = BenchmarkRunner.Run<HashHelperTester>();

            Console.ReadLine();
        }
    }
}
