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

    }
}
