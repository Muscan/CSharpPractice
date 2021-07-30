using System;
using static CSharpPractice.Arrays;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, -1, 330, 77, 12, 32, 56, 6, -1111, 66, 88, 99, 45, 24, 567 };
            DisplayArray(array);
            Console.WriteLine("Sum of array is: " + SumArray(array));
            Console.WriteLine("Product of the array is: " + ProductArray(array));
            Console.WriteLine("Product of even numbers is: "+ProductEvenArray(array));
            Console.WriteLine("Nr. of even numbers is: " + EvenNrArray(array));
            Console.WriteLine("Max nr. from an array: " + MaxNrArray(array));
            Console.WriteLine("Max even nr. from an array: " + MaxEven(array));
            Console.WriteLine("Sum. of negative numbers from an array: " + SumNegative(array));
        }
    }
}
