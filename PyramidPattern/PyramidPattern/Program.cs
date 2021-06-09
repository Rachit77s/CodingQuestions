using System;

namespace PyramidPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintPyramid();
            PrintHillPattern();
            PrintPyramidInterview();
            Print();
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }

        static void Print()
        {
            int numberoflayer = 6, Space, Number;
            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write('*');
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        static void PrintPyramidInterview()
        {
            //Rows are increasing
            //Spaces are decreasing from the bottom
            //Columns are decreasing from the bottom
            //Spaces depend on colums
            int n = 5;

            //rows
            for (int i = 1; i <= n; i++)
            {
                //For spacing
                for (int j = i; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                //for (int k = (i - 1); k >= 1; k--)
                //{
                //    Console.Write("*");
                //}

                Console.WriteLine();
            }
        }

        static void PrintPyramid()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j=i; j <= 6; j++)
                {
                    Console.Write(" ");
                }
                   
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }

        static void PrintHillPattern()
        {
            int n = 5;

            for (int i=1; i<=n; i++)
            {
                for (int j=i; j<=n; j++)
                {
                    Console.Write(" ");
                }

                for (int j=1; j<i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}


//1 decreasing space
// 2 increasing tirnagle *
// 