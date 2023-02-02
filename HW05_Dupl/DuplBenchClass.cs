using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelDuplNS;
using BenchmarkDotNet.Attributes;

namespace DuplBenchNS
{
    public class DuplBench
    {
        private string text = "A string is an object object  object object of type String whose value is text text. Internally, the  text text text is  stored stored stored as a sequential read-only collection of Char objects. " +
            "There's no null-terminating character character at the end of a C# string; therefore therefore therefore a C# string string can  can cancontain any number of embedded null characters (''). " +
            "The Length property property propertyof a string represents represents represents the number of Char objects it contains, not the number of Unicode characters. To access the individual" +
            "Unicode code points in a string string string, use the StringInfo object object.";

        [Benchmark]
        public void DelGenBench()
        {
            DelDupl.DelGen(text);
        }

        [Benchmark]
        public void DelCompBench()
        {
            DelDupl.DelComp(text);
        }

        [Benchmark]
        public void DelNonCompBench()
        {
            DelDupl.DelNonComp(text);
        }

    }
}
