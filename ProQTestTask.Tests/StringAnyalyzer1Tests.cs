using ProQTestTask.Main.StringAnalyzers;
namespace ProQTestTask.Tests
{
    public class StringAnalyzer1Tests
    {
        [Theory]
        [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15",
                    "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz")]
        public void Analyze_CorrectAnswer(string input, string output)
        {
            var analyzer = new StringAnalyzer1 ();

            var answer = analyzer.Analyze(input);

            Assert.Equal(output, answer);

        }
    }
}