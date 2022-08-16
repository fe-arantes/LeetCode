namespace RomanToInteger.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Test1(string input, int output)
        {
            var result = new Solution().RomanToInt(input);

            Assert.Equal(output, result);
        }
    }
}