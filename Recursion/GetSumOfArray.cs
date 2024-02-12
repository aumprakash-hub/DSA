namespace Recursion;

public class GetSumOfArray
{
    internal static int SumOfArray(int[] arrValue)
    {
        int size = arrValue.Length;

        if (size == 0) { return 0; }
        if (size == 1) { return arrValue[0]; }

        int startIndex = 0;
        
        arrValue = arrValue.Skip(startIndex).ToArray();
        int remainingValueSum = SumOfArray(arrValue);
        int sum = arrValue[startIndex] + remainingValueSum;
        
        startIndex++;
        return sum;
    }
}