using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Fibonacci Generator-----");
            Console.Write("Please enter the number of steps: ");
            string input = Console.ReadLine();

            int number;
            if (int.TryParse(input, out number))
            {
                int a = 0;
                int b = 1;

                if (number <= 0)
                    Console.WriteLine("Please enter a positive number");

                else if (number == 1)
                    Console.WriteLine("\n0"); 

                else if (number == 2)
                    Console.WriteLine("\n0, 1");

                else
                {
                    Console.Write("\n0, 1");

                    for (int i = 3; i <= number; i++)
                    {
                        int next = a + b;
                        Console.Write($", {next}");

                        a = b;
                        b = next;
                    }
                }
            }
            else
                Console.WriteLine("Please enter a valid number!");

            Console.WriteLine();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
