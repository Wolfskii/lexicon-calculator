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
                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        Addition();
                        break;

                    case "2":
                        Subtraction();
                        break;

                    case "3":
                        Multiplication();
                        break;

                    case "4":
                        Division();
                        break;

                    case "0":
                        Console.WriteLine("Stänger av...");
                        continueMenu = false;
                        break;
                }
            }
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

        public static void Addition()
        {
            Console.WriteLine("Addition\n-----------------------");
            double x = GetNumberInput("Ange den första termen:");
            double y = GetNumberInput("Ange den andra termen:");

            double sum = x + y;

            Console.WriteLine($"{x} + {y} = {sum}");
        }

        public static void Subtraction()
        {
            Console.WriteLine("Subtraktion\n-----------------------");
            double x = GetNumberInput("Ange den första termen:");
            double y = GetNumberInput("Ange den andra termen:");

            double difference = x - y;

            Console.WriteLine($"{x} - {y} = {difference}");
        }

        public static void Multiplication()
        {
            Console.WriteLine("Multiplikation\n-----------------------");
            double x = GetNumberInput("Ange den första faktorn:");
            double y = GetNumberInput("Ange den andra faktorn:");

            double product = x * y;

            Console.WriteLine($"{x} x {y} = {product}");
        }

        public static void Division()
        {
            Console.WriteLine("Division\n-----------------------");
            double x = GetNumberInput("Ange täljare:");
            double y = GetNumberInput("Ange nämnare:");

            double quotient = x / y;

            Console.WriteLine($"{x} / {y} = {quotient}");
        }

        public static double GetNumberInput(string question)
        {
            double inputNumber = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(question);
                validInput = double.TryParse(Console.ReadLine(), out inputNumber);
                Console.WriteLine();
            }

            return inputNumber;
        }
    }
}
