using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace ProQTestTask.Main.StringAnalyzers
{
    internal abstract class BaseStringAnalyzer
    {
        protected OrderedDictionary replaceDictionary;

        public BaseStringAnalyzer()
        {
            replaceDictionary = new OrderedDictionary();
        }

        public string Analyze(string expression)
        {
            var newString = ParseString(expression);
            newString = Replace(newString);
            return string.Join(", ", newString);
        }

        protected string[] ParseString(string expression)
        {
            return expression.Split(", "); 
        }

        protected virtual string[] Replace(string[] expression)
        {
            StringBuilder replacement = new StringBuilder();
            string[] newExpression = new string[expression.Length];
            expression.CopyTo(newExpression, 0);
            int number;

            for (int i = 0; i < expression.Length; i++)
            {

                if (int.TryParse(expression[i], out number))
                {
                    replacement.Clear();

                    foreach (string key in replaceDictionary.Keys)
                    {
                        if (number % int.Parse(key) == 0)
                        {
                            replacement.Append(replaceDictionary[key] + "-");

                        }
                    }

                    if (replacement.Length != 0)
                    {
                        replacement.Remove(replacement.Length - 1, 1);
                        newExpression[i] = replacement.ToString();
                    }

                }


            }

            return newExpression;
        }

    }
}
