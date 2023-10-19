using ProQTestTask.Main.StringAnalyzers;
using System.Collections.Specialized;

namespace ProQTestTask.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new StringAnalyzer1();
            var s2 = new StringAnalyzer2();
            var s3 = new StringAnalyzer3();

            Console.WriteLine(s1.Analyze("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15"));
            Console.WriteLine(s1.Analyze("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15"));
            Console.WriteLine(s2.Analyze("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,60,105,420"));
            Console.WriteLine(s3.Analyze("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,60,105,420"));

        }
    }
}