using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.Clear();
                ShowMenu();

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("1");
                        break;

                    case "2":

                        Console.WriteLine("2");
                        break;

                    case "3":

                        Console.WriteLine("3");
                        break;

                    case "4":

                        Console.WriteLine("4");
                        break;

                    case "0":

                        Console.WriteLine("0");
                        continueMenu = false;
                        break;
                }
            }


            // Meny (som forsätter till avstängning)
            // Addition
            // Subtraktion
            // Multiplikation
            // Division
            // Avsluta applikation
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Miniräknare:");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Avsluta");
        }

        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static int Subtract(int x, int y)
        {
            return (x - y);
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }

        public static int Divide(int x, int y)
        {
            return (x / y);
        }
    }
}
