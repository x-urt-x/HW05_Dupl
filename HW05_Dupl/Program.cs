
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using DelDuplNS;
using DuplBenchNS;
using System.Text;

namespace HW05_Dupl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(DelDupl.DelComp(Console.ReadLine()));

            //BenchmarkRunner.Run<DuplBench>();
        }


    }
}