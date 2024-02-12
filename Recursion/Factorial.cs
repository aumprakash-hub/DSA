namespace Recursion;

public class Factorial
{
    static internal double GetFacorial(double value)
    {
        // Base condition
        if (value == 0) { return 1; }
        // 5! = 5 * 4!; 4! = 4 * 3! ; 3! = 3 * 2! ==> n! = n * (n-1)!
        double supportFactorial = GetFacorial(value - 1);
        double mainFactorial = value * supportFactorial;
        return mainFactorial;
    }
}

