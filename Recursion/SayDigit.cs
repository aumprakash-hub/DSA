namespace Recursion;

public class SayDigit
{
    internal static void Say_Digit(int value)
    {
        string[] digitArr = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        if (value == 0) { return; }

        int digit = value % 10;
        value = value / 10;

        Say_Digit(value);

        Console.WriteLine(digitArr[digit]);
    }
}