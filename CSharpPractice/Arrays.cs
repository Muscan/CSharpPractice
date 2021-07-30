using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpPractice
{
    class Arrays
    {
        //Function which display an array
        public static void DisplayArray(int[] arr)
        {
            Console.Write("The array is: ");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write((arr[i])+" ");
            }
            Console.WriteLine();
        }

        //Function for sum of an array
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        //Multiply in an array
        public static int ProductArray(int[] arr)
        {
            int product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }

            return product;
        }
    }
}
