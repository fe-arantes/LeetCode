namespace RichestCustomerWealth;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        var result = 0;

        foreach ( var account in accounts )
        {
            var wealth = account.Sum();

            if ( wealth > result )
            {
                result = wealth;
            }
        }

        return result;
    }
}
