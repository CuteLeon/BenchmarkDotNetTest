using BenchmarkDotNet.Attributes;
using BenchmarkDotNetTarget;

namespace BenchmarkDotNetTest
{
    public class HashHelperTester
    {
        [Benchmark]
        public void TestMD5()
        {
            HashHelper.CalcMD5("https://www.baidu.com/img/bd_logo1.png");
        }

        [Benchmark]
        public void TestSHA1()
        {
            HashHelper.CalcSHA1("https://www.baidu.com/img/bd_logo1.png");
        }
    }
}
