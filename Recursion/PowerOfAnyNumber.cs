namespace Recursion;

public class PowerOfAnyNumber
{
    internal static int GetPowerOfAnyNumber(int a, int b)
    {
        System.Console.WriteLine($"Value of a : {a}, b is:  {b} \n");
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
        System.Console.WriteLine($"Answer is : {answer} \n");
        
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