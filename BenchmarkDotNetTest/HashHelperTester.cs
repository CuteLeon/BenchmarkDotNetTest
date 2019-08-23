using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNetTarget;

namespace BenchmarkDotNetTest
{
    // 测试运行时环境
    // [CoreRtJob, MonoJob]
    [CoreJob(baseline: true), ClrJob]
    // 监视内存
    [MemoryDiagnoser]
    [RPlotExporter, RankColumn]
    public class HashHelperTester
    {
        public List<string> TestTexts { get; set; } = new List<string>()
        {
            "",
            "the shortest English sentence containing 26 letters",
            string.Join("\n", Enumerable.Repeat("the shortest English sentence containing 26 letters",10))
        };

        // 使用参数源中的每个测试数据进行一次基准测试
        [ParamsSource(nameof(TestTexts))]
        public string TestText { get; set; }

        [GlobalSetup]
        public void Setup()
        {
        }

        // 基准测试（作为 BaseLine）
        [Benchmark(Baseline = true)]
        public void TestMD5()
        {
            HashHelper.CalcMD5(this.TestText);
        }

        [Benchmark]
        public void TestSHA1()
        {
            HashHelper.CalcSHA1(this.TestText);
        }
    }
}
