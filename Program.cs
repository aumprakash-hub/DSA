using System;
using BinaryDSA;
using Recursion;

// *********************************
// Binary search
// int[] arr = { 12, 15, 20, 47, 67, 79 };
// int result = BinarySearch.binarySearch(arr, arr.Length, 67);
// Console.Write($"Binary search Algo result: {result}");
// Console.ReadLine();
// *********************************
// Find Squre root by Binary search
// int squre = 105;
// long squre_Result = BinarySearch.squareRoot_By_BinarySearch(squre);
// Console.Write($"Binary search square root Algo result: {squre_Result}");
// Console.ReadLine();
// *********************************
//Factorial problem(Recursion)
// System.Console.WriteLine("Enter value to get factorial : ");
// double enterValue = Convert.ToDouble(Console.ReadLine()?.ToString());

// double Result = Factorial.GetFacorial(enterValue);
// System.Console.WriteLine($"Factorial of {enterValue} is : {Result}");
// Console.ReadLine();
// *********************************
// Say digit
// System.Console.WriteLine("Enter value to get say : ");
// int input = Convert.ToInt32(Console.ReadLine()?.ToString());

// SayDigit.Say_Digit(input);
// Console.ReadLine();
// // *********************************
// // Sum of array
// int[] arr = { 1, 2, 3, 5, 7 };
// int result = GetSumOfArray.SumOfArray(arr);
// System.Console.WriteLine($"Sum of array result is {result}");
// Console.ReadLine();

// *********************************
// Power of any number
System.Console.WriteLine("Enter value of a : ");
int a = Convert.ToInt32(Console.ReadLine()?.ToString());

System.Console.WriteLine("Enter value of b : ");
int b = Convert.ToInt32(Console.ReadLine()?.ToString());

int result = PowerOfAnyNumber.GetPowerOfAnyNumber(a, b);
System.Console.WriteLine($"Power of {a} to the power of {b} is {result}");
Console.ReadLine();