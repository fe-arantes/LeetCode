namespace FizzBuzz.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int input = 3;
            IList<string> output = new string[] { "1", "2", "Fizz" };

            var result = new Solution().FizzBuzz(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            int input = 5;
            IList<string> output = new string[] { "1", "2", "Fizz", "4", "Buzz" };

            var result = new Solution().FizzBuzz(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            int input = 15;
            IList<string> output = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            var result = new Solution().FizzBuzz(input);

            Assert.Equal(output, result);
        }
    }
}