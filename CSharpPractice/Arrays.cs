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

        //Product of the even numbers
        public static int ProductEvenArray(int[] arr)
        {
            int productEven = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    productEven *= arr[i];
                }
            }
            return productEven;
        }

        //Return nr. of even numbers
        public static int EvenNrArray(int[] arr)
        {
            int numberOfEven = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    ++numberOfEven;
                }
            }

            return numberOfEven;
        }
        //Max nr from an array
        public static int MaxNrArray(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        //Max even number
        public static int MaxEven(int[] arr)
        {
            int evenMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > evenMax && arr[i] % 2 == 0)
                {
                    evenMax = arr[i];
                }
            }

            return evenMax;
        }
        //Sum of negative numbers
        public static int SumNegative(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
