namespace RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        var result = 0;
        var oldValue = 0;

        foreach ( var symbol in s )
        {
            var newValue = RomanSymbols[symbol];

            if ( newValue > oldValue )
            {
                result += newValue - ( oldValue * 2 );
            }
            else
            {
                result += newValue;
            }

            oldValue = newValue;
        }

        return result;
    }

    public Dictionary<char, int> RomanSymbols => new Dictionary<char, int>
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000 },
    };
}