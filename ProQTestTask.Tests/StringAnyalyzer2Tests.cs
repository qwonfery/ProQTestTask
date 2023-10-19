using ProQTestTask.Main.StringAnalyzers;
namespace ProQTestTask.Tests
{
    public class StringAnalyzer2Tests
    {
        [Theory]
        [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420",
                    "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz")]
        public void Analyze_CorrectAnswer(string input, string output)
        {
            var analyzer = new StringAnalyzer2 ();

            var answer = analyzer.Analyze(input);

            Assert.Equal(output, answer);

        }
    }
}