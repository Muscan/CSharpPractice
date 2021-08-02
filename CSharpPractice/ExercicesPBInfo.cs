using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ExercicesPBInfo

    {  //! This is actually a right-angle triangle not a Pyramid but it`s made based on the requirements
        public static void Pyramid351(int nrOfLevelsForPyramid)

          
        {
            /*
          # 351 Pyramid

               Basic elements of language Repetitive structures Pyramid 

          Tags: Display of figures

              Statement
              See solutions 40624

          Requirement

          The natural number is read n. Display the following pyramid of numbers:

          1
          1 2
          1 2 3
          .......
          1 2 3 ... n

          Input data

          The program reads the number from the keyboard n.
          Output data

          The program displays the number on the screen 1, the numbers on the second line 1 2, the numbers on the third line 1 2 3, etc., on the nnumbers on the second line 1 2 3 ... n. On each line the numbers are separated by exactly one space.
          Restrictions and clarifications

              1 ≤ n ≤ 20


          Example

          Input data

          4

          Output data

         1
         1 2
         1 2 3
         1 2 3 4

          */
            for (int i = 1; i <= nrOfLevelsForPyramid; i++)//itertates the nr of columns
            {

                for (int j = 1; j <= i; j++)//iteretes the columns
                    Console.Write(j + " ");
                Console.WriteLine();
            }

        }
        
        public static void IsoscelTriangle(int nrOfLevelForTriangle)
        {
            //Function which displayes an Isoscel triangle
            for(int i=1; i<=nrOfLevelForTriangle; i++)
            {
                if (i < 10)
                    Console.Write(" ");
                for(int j=1; j<=nrOfLevelForTriangle-i;j++)
                    Console.Write("  ");
                for(int j=i; j>=1; j--)
                    Console.Write(j + " ");
                for(int j=2;j<=i;j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }

        public static void PrintNumbers3231(int nr)
      
        {
            /*
          # 3231 DisplayNumbers2

         Basic elements of language Repetitive structures DisplayNumbers2 

          Tags: no tags

          Statement
          See solutions 23830

          Requirement

          Give a natural number n. Display on one line the first nnon-zero natural numbers in ascending order, and on the next line the same numbers, but in descending order.
          Input data

          The program reads the number from the keyboard n.
          Output data

          The program displays on the screen, on lines different required numbers. The numbers on the same line are separated by a space.
          Restrictions and clarifications

          1 ≤ n ≤ 100


          Example

          Input data

          5

          Output data

          1 2 3 4 5 
          5 4 3 2 1 

          */


            for (int i = 1; i <= nr; i++)
            {

                Console.Write(i + " ");//Displayes the numbers ascending

            }
            Console.Write("\n");
            for (int i = nr; i >= 1; i--)//Iterates from end to begin
            {
                Console.Write(i + " ");//Displayes numbers descending
            }
        }

        public static void Display10Columns(int number)
        {
            //Function which dispalyes only 10 numbers on a row
            for (int i=1; i<=number; i++){
                Console.Write(i+ " ");
                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.Write("\n");
            int contor = 0;
            for (int i = number; i >= 1; i--)//Iterates from end to begin
            {
                Console.Write(i + " ");//Displayes numbers descending
                contor++;
                if (contor == 10)
                {
                    Console.WriteLine();
                    contor = 0;
                }
                
            }


          


        }

        public static void ScaleNumbers1569(int nr)
        {
          /*
            # 1569 Scale of Numbers

           Basic elements of language Repetitive structures Scale of Numbers 

            Tags: Display of figures

                Statement
                See solutions 13785

            Requirement

            A natural number is read n. Display a figure similar to the one in the example.
            Input data

            The program reads the number from the keyboard n.
            Output data

            The program will display the figure, similar to the example.
            Restrictions and clarifications

                1 ≤ n ≤ 9


            Example

            entry

            3

            Exit

            1
            22
            22
            333
            333
            333

            Explanation

            The number 1was displayed only once, in a single row. The number 2to display 2times, in 2rows. 
            The number 3was displayed several 3times, one by one 3.
            */
            for (int i = 1; i <= nr; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }


        }

        public static void PrintOddNumbers3233(int n)
        {
            /*
            # 3233 DisplayImperatureNumbers1

              Basic elements of language Repetitive structures Display OddNumbers1 

            Tags: no tags

                Statement
                See solutions 16764

            Requirement

            Give a natural number n. Display in descending order the odd natural numbers less than or equal to n.
            Input data

            The program reads the number from the keyboard n.
            Output data

            The program displays on the screen in descending order the odd natural numbers less than or equal to n, separated by exactly one space.
            Restrictions and clarifications

                1 ≤ n ≤ 100


            Example

            Input data

            10

            Output data

            9 7 5 3 1

            */
            if (n % 2 == 0)
                n--;
            for (int i = n; i >= 1; i -= 2)
            {
                Console.Write(i + " ");
            }

        }

        public static void Print7AtEnd(int n)
        {
            //Function which prints the numbers with 7 at the end
            for (int i = 7; i <= n; i += 10)
            {
                Console.Write(i + " ");
            }
        }

        public static void PowerDisplay348(int pow, int number)
        {
        /*
            # 348 Power Display

              Basic elements of language Repetitive structures Power display 

            Tags: Display values

                Statement
                See solutions 38837

            Requirement

            Give two nonzero natural numbers nand p. Display in ascending order its powers nless than or equal to p.
            Input data

            The program reads from the keyboard nand numbers p.
            Output data

            The program displays on the screen, in ascending order, its powers nless than or equal to p, separated by a space.
            Restrictions and clarifications

                2 ≤ n ≤ 10
                1 ≤ p < 1.000.000.000


            Example

            Input data

            3 100

            Output data

            1 3 9 27 81

            */
            for (int powerDisplay = 1; powerDisplay <= number; powerDisplay *= pow)
            {
                Console.Write(powerDisplay + " ");
            }
        }

        public static void HowManyEven1261()

        {
       /*
            # 1261 CatePare

            Basic elements of language Repetitive structures CatePare 

            Tags: Counting values

                Statement
                See solutions 121577

            Requirement

            Numbers are read from the keyboard until zero appears. Determine how many of them were even.
            Input data

            The program reads whole numbers from the keyboard. The reading ends when the value is entered 0, which will not be counted.
            Output data

            The program displays the number on the screen K, representing the number of even read numbers.
            Restrictions and clarifications

                the numbers read belong to the range (-1.000.000,1.000.000);
                if no number is even the message will be displayed Does not exist.


            Example

            entry

            1 2 3 4 5 6 0

            Exit

            3

            */
                        int k = 0;
            int numberToRead;
            Console.Write("Insert a number to check ");

            numberToRead = int.Parse(Console.ReadLine());

            while (numberToRead != 0)
            {
                if (numberToRead % 2 == 0)
                    k++;
                Console.Write("Insert the next number to check ");
                numberToRead = int.Parse(Console.ReadLine());

            }
            if (k == 0)
            {
                Console.Write("Does not exists");
            }
            else//if (k!=0)
            {
                Console.Write("The total nr. of even numbers = " + k);
            }


        }

    }
}
