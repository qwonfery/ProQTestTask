using ProQTestTask.Main.StringAnalyzers;
namespace ProQTestTask.Tests
{
    public class StringAnalyzer3Tests
    {
        [Theory]
        [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420",
                    "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz")]
        [InlineData("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420",
                    "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz")]
        public void Analyze_CorrectAnswer(string input, string output)
        {
            var analyzer = new StringAnalyzer3 ();

            var answer = analyzer.Analyze(input);

            Assert.Equal(output, answer);

        }
    }
}