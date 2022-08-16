namespace RunningSumOf1dArray.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            int[] output = new int[] { 1, 3, 6, 10 };

            var result = new Solution().RunningSum(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 1, 1, 1, 1, 1 };
            int[] output = new int[] { 1, 2, 3, 4, 5 };

            var result = new Solution().RunningSum(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            int[] input = new int[] { 3, 1, 2, 10, 1 };
            int[] output = new int[] { 3, 4, 6, 16, 17 };

            var result = new Solution().RunningSum(input);

            Assert.Equal(output, result);
        }
    }
}