using System;
using static CSharpPractice.Arrays;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, -1, 330, 77, 12, 32, 56, 6, -1111, 66, 88, 99, 45, 24, 567, 999 };
            DisplayArray(array);
            Console.WriteLine("Sum of array is: " + SumArray(array));
            Console.WriteLine("Product of the array is: " + ProductArray(array));
            Console.WriteLine("Product of even numbers is: " + ProductEvenArray(array));
            Console.WriteLine("Nr. of even numbers is: " + EvenNrArray(array));
            Console.WriteLine("Max nr. from an array: " + MaxNrArray(array));
            Console.WriteLine("Max even nr. from an array: " + MaxEven(array));
            Console.WriteLine("Sum. of negative numbers from an array: " + SumNegative(array));
            Console.WriteLine("Nr. of Prime numbers from an array: " + PrimeNumbers(array));
            Console.WriteLine("Nr val Odd: " + NrValOdd(array));
            Console.WriteLine("Absolut value from Even - Odd: " + AbsValue(array));
            Console.WriteLine("Nr. of numbers which divide with the last nr.: " + MultiplesLastElement(array));
            PairsOfArray(array);
            Console.WriteLine("Min. value from the array is: " + MinValueOfArray(array));
            Console.WriteLine("Max value from an array is: " + MaxValueOfArrayV2(array));
            Console.WriteLine(MinMaxValuesOfArray(array));
            Console.WriteLine("Index of first even elem. is: "+PositionFirstEvenElement(array));
            Console.WriteLine("Index of last even elem. is: "+PositionLastEvenElement(array));
            Console.WriteLine("Sum of elements between first and last even number "+SumForNrBetweenFirstLastPositionEvenElements(array));
            Console.WriteLine("Avg. of array is: "+AverageArray(array));
            Console.WriteLine("Nr. of numbers greater than the avg of array are: "+NrOfNumbersGreaterThanAvg(array));
            if (NumberInInterval(10, 200, 200)) Console.WriteLine("Nr. in range ");
            else Console.WriteLine("Nr. not in range");
            Console.WriteLine("Total nr. of numbers which are in range is: " + NrOfNumbersBetweenFirstAndLastElem(array));
            


        }
    }
}
