using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculyator";
            Console.WriteLine("\t\tCalculator");


            Console.Write("Enter number 1: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter number 2: ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {

                while (true)
                {
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subt");
                    Console.WriteLine("3. Mult");
                    Console.WriteLine("4. Div");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Write("--------------------\n");
                    switch (choice)
                    {
                        case 1:
                            number1 += number2;
                            Console.WriteLine("Add: " + number1);
                            Console.Write("--------------------\n");
                            break;
                        case 2:
                            number1 -= number2;
                            Console.WriteLine("Subs: " + number1);
                            Console.Write("--------------------\n");
                            break;
                        case 3:
                            number1 *= number2;
                            Console.WriteLine("Mult: " + number1);
                            Console.Write("--------------------\n");
                            break;
                        case 4:
                            number1 /= number2;
                            Console.WriteLine("Div: " + number1);
                            Console.Write("--------------------\n");
                            break;
                        default:
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Wrong!!!");
            }

        }
    }
}



