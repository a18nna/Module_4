using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском ");
            string color = Console.ReadLine().ToLower();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Your favorite color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your favorite color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Youe favorite color is cyan!");
            }

            Console.ReadKey();
            /* string A;
             string B;
             bool C = A != B;

             int A, B;
             double X, Y;
             bool C = (A < B) | (X > Y);

             var a = 6;
             var b = 7;

             var c = a != b ? a + b : b;

             Console.WriteLine(c);*/
        }
    }
}
