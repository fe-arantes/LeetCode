namespace RichestCustomerWealth.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[][] input = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };

            int output = 6;
            var result = new Solution().MaximumWealth(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            int[][] input = new int[][] {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            };

            int output = 10;
            var result = new Solution().MaximumWealth(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            int[][] input = new int[][] {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            };

            int output = 17;
            var result = new Solution().MaximumWealth(input);

            Assert.Equal(output, result);
        }
    }
}