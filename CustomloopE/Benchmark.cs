using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomloopE
{
    public class Benchmarks
    {
        [Benchmark]
        public void NomalLoop() {

            for(var i=1; i<=10; i++)
            {
                Dosomething(i);
            }
        }
        [Benchmark]
        public void ExtendedLoop() {
            foreach (var i in 0..10)
            {
                Dosomething(i);
            }
        }
        public void Dosomething(int i)
        {
           // Console.WriteLine(i);
        }

    }
}
