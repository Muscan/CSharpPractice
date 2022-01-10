using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
     class ArraysUsefull
    {
        //Function which sorts a specific element iterating through the whole array

        public static void DirectSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

        }

        //Function which sorts comparing the current element with the next one
        public static void BubbleSort(int[] array)
        {
            bool flag = false;

            do
            {
                flag = true;

                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;
                        flag = false;
                    }
                }
            } while (!flag);

        }

        public static void BubbleSort2(int[] array)
        {
            //using a flag to compare the elements and check if they need to be changed
            //When no neighbor needs to be changes, flag remains 1
            //The array is sorted
            int flag;//1 if not sorted, 0 if sorted. 
            do
            {
                flag = 1;//suppose in the beggining that it is sorted
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //check if the current elem is > than the next to the right
                    if (array[i] > array[i + 1])
                    {         
                        int temporary = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temporary;
                        flag = 0;
                    }
                }
            } while (flag == 0);
        }
        
        public static int[] DeleteAnElemFromAnArray(int[] array, int position)
        {
            //Function which deletes an elemen. from a specified position
            //Eg. arr{3,5,2}, position=1 => {3,2}
            for (int i = position; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            int[] nou = new int[array.Length - 1];

            for (int i = 0; i < nou.Length; ++i)
            {
                nou[i] = array[i];
            }

            return nou;
        }

        public static int[] InsertionFunction(int[] v, int position, int nrInserted)
        {
            int[] nou = new int[v.Length + 1];

            int i;
            for (i = 0; i < v.Length; ++i)
            {
                nou[i] = v[i];
            }

            for (i = v.Length - 1; i >= position; --i)
            {
                nou[i + 1] = nou[i];
            }

            nou[position] = nrInserted;
            return nou;
        }

        public static bool BinarySearch(int[] numbers, int searchedNumber)
        {

            BubbleSort(numbers);

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                if (numbers[middleIndex] == searchedNumber)
                {
                    return true;
                }
                else if (numbers[middleIndex] < searchedNumber)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    leftIndex = middleIndex - 1;
                }
            }
            return false;
        }


    }
}
