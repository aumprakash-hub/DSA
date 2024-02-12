using System;

namespace BinaryDSA;

public class BinarySearch
{

    public static int binarySearch(int[] arr, int size, int key)
    {
        int startIndex = 0;
        int endIndex = size - 1;

        int midIndex = startIndex + (endIndex - startIndex) / 2;
        while (startIndex <= endIndex)
        {
            if (arr[midIndex] == key)
            {
                return midIndex;
            }
            // go to Right part of array
            else if (key > arr[midIndex])
            {
                startIndex = midIndex + 1;
            }
            else if (key < arr[midIndex])
            {
                endIndex = midIndex - 1;
            }

            midIndex = startIndex + (endIndex - startIndex) / 2;
        }
        return -1;
    }

    public static long squareRoot_By_BinarySearch(int value)
    {
        long startIndex = 0;
        long endIndex = value;

        long midIndex = startIndex + (endIndex - startIndex) / 2;
        long answer = -1;
        while (startIndex <= endIndex)
        {
            long squre = midIndex * midIndex;
            if (squre == value)
            {
                return midIndex;
            }

            if (squre < value)
            {
                answer = midIndex;
                startIndex = midIndex + 1;
            }
            else
            {
                endIndex = midIndex - 1;
            }
            midIndex = startIndex + (endIndex - startIndex) / 2;
        }
        return answer;
    }

}