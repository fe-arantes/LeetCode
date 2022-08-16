namespace FizzBuzz;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> answer = new List<string>();

        for ( int i = 1; i <= n; i++ )
        {
            var result = string.Empty;

            if ( i % 3 == 0 )
            {
                result += "Fizz";
            }

            if ( i % 5 == 0 )
            {
                result += "Buzz";
            }

            if ( string.IsNullOrWhiteSpace(result) )
            {
                result = i.ToString();
            }

            answer.Add(result);
        }

        return answer;
    }
}
