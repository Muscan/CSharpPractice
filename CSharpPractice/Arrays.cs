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
            Console.Write("");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write((arr[i]).ToString() + " ");
            }
            //Console.WriteLine();
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
                    numberOfEven++;
                }
            }

            return numberOfEven;
        }

        //Max nr from an array
        public static int MaxNrArray(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
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

        //Nr. of prime numbers
        //{10,13}
        public static int PrimeNumbers(int[] arr)
        {
            int prime = 0;
            //navigate through the array
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;//suppose isPrime
                //divide the number from index i to 2,
                //arr[i] = 10
                //j = 2, 3, 4, 5
                //is Prime = false
                for (int j = 2; j < arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    ++prime;
                }
            }

            return prime;
        }

        //Nr. of odd nambers
        public static int NrValOdd(int[] arr)
        {
            int countOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    ++countOdd;
                }
            }

            return countOdd;
        }

        //Absolute value from Even-Odd numbers
        //Abs is the non-negative value of x without regard to its sign
        public static int AbsValue(int[] arr)
        {
            return Math.Abs(EvenNrArray(arr) - NrValOdd(arr));
        }

        //Number of numbers which divide with the last nr. 
        public static int MultiplesLastElement(int[] arr)
        {
            int lastElementOfArray = arr[arr.Length - 1];
            int multiplesCounter = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % lastElementOfArray == 0)
                {
                    ++multiplesCounter;
                }
            }
            return multiplesCounter;
        }


        public static void PairsOfArray(int[] myArray)
        {
            int i = 0;
            //Starts from the first and last elem
            //At the end i++ goes to the next and j-- comes to the previous
            //i<j makes sure that the iteration from right(j) does not come lower to left than(i)
            Console.WriteLine("Pairs of the given array are:  ");
            for (int j = myArray.Length - 1; i < j; j--)
            {
                //Displayes the paris from: first last, second last-1...
                Console.WriteLine("[" + myArray[i] + ", " + myArray[j] + "]");
                i++;
            }
        }
        //Min. value from an array
        public static int MinValueOfArray(int[] arr)
        {
            int minValue = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            return minValue;
        }
        //Max value from an array with iteration from arr[i](first)
        public static int MaxValueOfArrayV2(int[] arr)
        {
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            return maxValue;
        }
        public static String MinMaxValuesOfArray(int[] arr)
        {
            int var10000 = MinValueOfArray(arr);
            return "The minimum value from the array is " + var10000 + " , and the max value is " + MaxNrArray(arr);
        }

        //Position of the first even element
        public static int PositionFirstEvenElement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        //Function which return the position of last even element
        public static int PositionLastEvenElement(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    return i;
                }
            }

            return -1;
        }
        //Function for adding adding numbers between first and last even element
        public static int SumForNrBetweenFirstLastPositionEvenElements(int[] arr)
        {
            int sum = 0;

            for (int i = PositionFirstEvenElement(arr); i <= PositionLastEvenElement(arr); i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int AverageArray(int[] arr)
        {
            return SumArray(arr) / arr.Length;
        }

        //Function which returns the number of the elements which are greater than the Avg of arrray
        public static int NrOfNumbersGreaterThanAvg(int[] arr)
        {
            int countElemente = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (AverageArray(arr) < arr[i])
                {
                    ++countElemente;
                }
            }

            return countElemente;
        }
        //Function which checks if a number belongs to an interval(eg: 1,10, 3 -> 3 is between 1 and 10)
        public static bool NumberInInterval(int firstNumber, int lastNumber, int controlNumber)
        {
            if (firstNumber < lastNumber)
            {
                if (controlNumber > firstNumber && controlNumber < lastNumber)
                    return true;

                else
                    return false;

            }
            else
            {
                if (controlNumber < firstNumber && controlNumber > lastNumber)
                    return true;
                else
                    return false;
            }
        }

        //Function which returns the number of elements which are between first and last element
        //based also on the function NumberInInterval
        public static int NrOfNumbersBetweenFirstAndLastElem(int[] arr)
        {
            int countElements = 0;
            int firstNumber = arr[0];
            int lastNumber = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (NumberInInterval(firstNumber, lastNumber, arr[i]))
                {
                    ++countElements;
                }
            }

            return countElements;

        }

        public static void ElementsRightToLeft(int[] arr)
        {
            Console.WriteLine("<-Right to left ");
            for (int i = arr.Length - 1; i >= 0; --i)
            {
                Console.Write( arr[i] +" ");
            }

        }
        public static int SumEvenValues(int[] arr)
        {
            int sumEvenValues = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEvenValues += arr[i];
                }
            }

            return sumEvenValues;
        }

        public static int SumValuesOnEvenIndexPosition(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }


        public static int NumbersDivideWith3OddIndexPosition(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 3 == 0 && i % 2 == 1)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        public static int PositionLastElem(int[] arr)
        {
            int i = arr.Length - 1;
            return i >= 0 ? i : 0;
            /*if ( i >= 0)
                return i;
            else
                return 0;
            */
        }

        public static int PositionFirstElem(int[] arr)
        {
            int i = 0;
            return i < arr.Length ? i : 0;
        }

        public static int EvenPairs(int[] arr)
        {
            int count = 0;
            int i = 0;

            for (int j = arr.Length - 1; i < j; --j)
            {
                if (arr[i] % 2 == 0 && arr[j] % 2 == 0)
                    //It groups a number from the begining with a number from the end
                    //when they are Even
                {
                    ++count;
                }

                ++i;
            }

            return count;
        }


    }
}
