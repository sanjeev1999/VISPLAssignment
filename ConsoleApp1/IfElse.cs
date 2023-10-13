using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IfElse
    {
        public static void loop()
        {


            // if-else statement
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine(number + " is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine(number + " is zero.");
            }
            else
            {
                Console.WriteLine(number + " is negative.");
            }

            // for loop to print numbers 1 to 5
            Console.WriteLine("\nPrinting numbers 1 to 5 using for loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " ");
            }

            // while loop to print even numbers up to 10
            Console.WriteLine("\n\nPrinting even numbers up to 10 using while loop:");
            int j = 2;
            while (j <= 10)
            {
                Console.Write(j + " ");
                j += 2;
            }

            // do-while loop to print odd numbers up to 9
            Console.WriteLine("\n\nPrinting odd numbers up to 9 using do-while loop:");
            int k = 1;
            do
            {
                Console.Write(k + " ");
                k += 2;
            } while (k <= 9);

            // Nested loops to print a pattern
            Console.WriteLine("\n\nPrinting a pattern using nested loops:");
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

}
