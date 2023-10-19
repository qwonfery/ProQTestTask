using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQTestTask.Main.StringAnalyzers
{
    internal class StringAnalyzer1 : BaseStringAnalyzer
    {

        public StringAnalyzer1() : base()
        {
            replaceDictionary.Add("3", "fizz");
            replaceDictionary.Add("5", "buzz");
        }

    }
}
