using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Functions
    {
        public static int MinNumber(int number)
        {
            int min;
            for (min = number % 10; number != 0; number /= 10)
            {
                int digit = number % 10;
                if (digit < min)
                {
                    min = digit;
                }
            }

            return min;
        }

        public static int NumberOfDigits(int number)
        {
            bool digitNumber = false;

            int count;
            for (count = 0; number != 0; number /= 10)
            {
                ++count;
            }

            return count;
        }

        public static  int EvenDigits(int number)
        {
            int count = 0;
            if (number == 0)
            {
                return 1;
            }
            else
            {
                for (; number != 0; number /= 10)
                {
                    if (number % 2 == 0 && number != 0)
                    {
                        ++count;
                    }
                }

                return count;
            }
        }

        public static int MaxDigit(int number)
        {
            int maxim;
            for (maxim = number % 10; number != 0; number /= 10)
            {
                int digit = number % 10;
                if (digit > maxim)
                {
                    maxim = digit;
                }
            }

            return maxim;
        }

        public static int OddDigit(int number)
        {
            return NumberOfDigits(number) - EvenDigits(number);
        }

        public static  bool SameDigits(int number)
        {
            for (int lastDigit = number % 10; number != 0; number /= 10)
            {
                int digit = number % 10;
                if (digit != lastDigit)
                {
                    return false;
                }
            }

            return true;
        }

        public static int SmallestEven(int number)
        {
            int smallestDigit;
            for (smallestDigit = 10; number != 0; number /= 10)
            {
                int digit = number % 10;
                if (digit < smallestDigit && digit % 2 == 0)
                {
                    smallestDigit = digit;
                }
            }

            return smallestDigit;
        }

        public static int ReversedNr(int number)
        {
            int reversedNumber = 0;

            for (bool var3 = false; number != 0; number /= 10)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
            }

            return reversedNumber;
        }

    

      
    }
}
