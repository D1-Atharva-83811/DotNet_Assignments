using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int choice;
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Sub");
                Console.WriteLine("3.Mul");
                Console.WriteLine("4.Div");
                Console.WriteLine("Enter your choice:");
                choice=Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("Addition is: " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction is: " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication is: " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division is: " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
