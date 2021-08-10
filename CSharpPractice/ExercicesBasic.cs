using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ExercicesBasic
    {
        public static void PrintArray(int[] array)
        {
           
            for (int i = 0; i < array.Length; i++)
            Console.Write($" {array[i]} ");
        }


        public static void AddTwoNumbers(int number1, int number2)
        {

            int result = 0;
             result = number1 + number2; 

            Console.WriteLine(result);
        }

        public static void AddNNumbers(int [] numbers)
        {
            int result = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                result += numbers[i];//result = result +number[i]
            }
            Console.Write($"Result for array [");
            PrintArray(numbers);
            Console.Write($"] is {result}");
        }

        public static void SignChar(int n1, int n2, char s)
        {
            int result;
            if (s == '-')
            {
                result = n1 - n2;
            }
            else if (s == '+')
            {
                result = n1 + n2;
            }
            else if (s == '*')
            {
                result = n1 * n2;
            }
            else if (s == '/')
            {
                result = n1 / n2;
            }
            else
            {
                Console.WriteLine($"Operation sign {s} differs from  +-*/ ");
                return;
            }


            Console.WriteLine($"Result is:{result}");

        }


        public static void SwitchSign(int n1, int n2, char s)
        {
            int result;
            switch (s)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine($"Operation sign {s} differs from  +-*/ ");
                    return;
            }
            Console.WriteLine($"Result is:{result}");
        }
    }
}
