namespace RunningSumOf1dArray;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var oldSum = 0;
        var result = new List<int>();

        foreach ( var num in nums )
        {
            var sum = num + oldSum;
            result.Add(sum);

            oldSum = sum;
        }

        return result.ToArray();
    }
}
