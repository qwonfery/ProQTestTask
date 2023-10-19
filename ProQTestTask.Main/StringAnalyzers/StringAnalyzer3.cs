using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQTestTask.Main.StringAnalyzers
{
    internal class StringAnalyzer3 : BaseStringAnalyzer
    {

        public StringAnalyzer3() : base()
        {
            replaceDictionary.Add("3", "dog");
            replaceDictionary.Add("5", "cat");
            replaceDictionary.Add("4", "muzz");
            replaceDictionary.Add("7", "guzz");
        }

        protected override string[] Replace(string[] expression)
        {
            return base.Replace(expression).Select(x => x.Replace("dog-cat", "good-boy")).ToArray();
        }

    }
}
