using System;
using static CSharpPractice.Arrays;
using static CSharpPractice.Functions;
using static CSharpPractice.ArraysUsefull;



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
            Console.Write("Avg. of array: ");
            DisplayArray(array);
            Console.WriteLine("is "+AverageArray(array));
            Console.WriteLine("Nr. of numbers greater than the avg of array are: "+NrOfNumbersGreaterThanAvg(array));

            if (NumberInInterval(10, 200, 200)) Console.WriteLine("Nr. in range ");
            else Console.WriteLine("Nr. not in range");

            Console.WriteLine("Total nr. of numbers which are in range is: " + NrOfNumbersBetweenFirstAndLastElem(array));

            // Functions
            int numberForFunctions = 1098726345;
            int numberForShortDisplay = 13278;
            Console.WriteLine("The min. digit from "+numberForFunctions+" is: "+ MinNumber(numberForFunctions));
            Console.WriteLine("Nr. of digits from "+numberForFunctions +" is: " + NumberOfDigits(numberForFunctions));
            Console.WriteLine("Nr. of even digits from "+numberForFunctions+" is: " + EvenDigits(numberForFunctions));
            Console.WriteLine("Max digit from "+numberForFunctions +" is: " + MaxDigit(numberForFunctions));
            Console.WriteLine("Odd digit from "+numberForFunctions+" is: "+OddDigit(numberForFunctions));
            Console.WriteLine("Smallest even from "+numberForFunctions+" is: "+SmallestEven(numberForFunctions));
            Console.WriteLine("Reversed number "+numberForShortDisplay+" is: "+ReversedNr(numberForShortDisplay));


            // ArraysUSefull
            int[] shortArray = new int[] {-1, 77, 2, 7 };
            DirectSort(shortArray);
            Console.Write("The sorted array using Direct Sort is: ");
            DisplayArray(shortArray);
            Console.WriteLine();

            BubbleSort(shortArray);
            Console.Write("The sorted array using Bubble Sort ");
            DisplayArray(shortArray);
            Console.WriteLine();


            int positionInArray = 1;
            Console.Write("The array after nr. at index " + positionInArray+ " was deleted is: ");
            DisplayArray(DeleteAnElemFromAnArray(shortArray,positionInArray));

            Console.WriteLine();
            int nrToInsert = 423;
            Console.Write("The new array after inserting at index  " + positionInArray +" the number "+ nrToInsert+ " is: ");
            DisplayArray(InsertionFunction(shortArray, positionInArray, nrToInsert));
            Console.WriteLine();



            int nrToSearch = 321;
            if(BinarySearch(shortArray,nrToSearch))
                Console.WriteLine(" Number "+ nrToSearch +" found in array ");
            else Console.Write("Number " + nrToSearch +" not found in ");
            DisplayArray(shortArray);

           



  
        }
    }
}
