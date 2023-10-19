using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQTestTask.Main.StringAnalyzers
{
    internal class StringAnalyzer2 : StringAnalyzer1
    {

        public StringAnalyzer2() : base()
        {
            replaceDictionary.Add("4", "muzz");
            replaceDictionary.Add("7", "guzz");
        }

    }
}
