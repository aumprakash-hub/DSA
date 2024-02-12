namespace Recursion;

public class PowerOfAnyNumber
{
    internal static int GetPowerOfAnyNumber(int a, int b)
    {
        // Base case
        if (b == 0)
        {
            return 1;
        }
        if (b == 1)
        {
            return a;
        }
        // Recursive function
        int answer = GetPowerOfAnyNumber(a, b / 2);
        //If Even
        if (b % 2 == 0)
        {
            return answer * answer;
        }
        else
        {
            return a * answer * answer;
        }
    }
}