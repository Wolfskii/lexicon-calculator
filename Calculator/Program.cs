using System;

namespace Calculator
{
    public class Program
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
                        PrintAddition();
                        break;

                    case "2":
                        PrintSubtraction();
                        break;

                    case "3":
                        PrintMultiplication();
                        break;

                    case "4":
                        PrintDivision();
                        break;

                    case "0":
                        Console.Clear();
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
            Console.WriteLine("0. Avsluta\n");
        }

        public static void PrintAddition()
        {
            bool continueOperation = true;

            while (continueOperation)
            {
                Console.Clear();
                Console.WriteLine("Addition\n-----------------------");
                double x = GetNumberInput("Ange den första termen:");
                double y = GetNumberInput("Ange den andra termen:");

                double sum = Addition(x, y);

                Console.WriteLine($"{x} + {y} = {sum}");

                continueOperation = !BackToMainMenu();
            }
        }

        public static void PrintSubtraction()
        {
            bool continueOperation = true;

            while (continueOperation)
            {
                Console.Clear();
                Console.WriteLine("Subtraktion\n-----------------------");
                double x = GetNumberInput("Ange den första termen:");
                double y = GetNumberInput("Ange den andra termen:");

                double difference = Subtraction(x, y);

                Console.WriteLine($"{x} - {y} = {difference}");

                continueOperation = !BackToMainMenu();
            }
        }

        public static void PrintMultiplication()
        {
            bool continueOperation = true;

            while (continueOperation)
            {
                Console.Clear();
                Console.WriteLine("Multiplikation\n-----------------------");
                double x = GetNumberInput("Ange den första faktorn:");
                double y = GetNumberInput("Ange den andra faktorn:");

                double product = Multiplication(x, y);

                Console.WriteLine($"{x} x {y} = {product}");

                continueOperation = !BackToMainMenu();
            }
        }

        public static void PrintDivision()
        {
            bool continueOperation = true;

            while (continueOperation)
            {
                Console.Clear();
                Console.WriteLine("Division\n-----------------------");
                double x = GetNumberInput("Ange täljare:");
                double y = 0;

                while (y == 0)
                {
                    y = GetNumberInput("Ange nämnare:");
                    if (y == 0) { Console.WriteLine("Fel! Nämnaren kan inte vara 0, försök igen."); }
                }

                double quotient = Division(x, y);

                Console.WriteLine($"{x} / {y} = {quotient}");

                continueOperation = !BackToMainMenu();
            }
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

        public static bool BackToMainMenu()
        {
            bool backToMainMenu = true;
            Console.WriteLine("\nTillbaka till huvudmenyn? (j/n)");

            bool continueAsk = true;

            while (continueAsk)
            {
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "j" || userInput == "ja")
                {
                    continueAsk = false;
                    backToMainMenu = true;
                } else if (userInput == "n" || userInput == "nej")
                {
                    continueAsk = false;
                    backToMainMenu = false;
                }
            }

            return backToMainMenu;
        }

        public static double Addition(double x, double y)
        {
            return x + y;
        }

        public static double Addition(double[] numbers)
        {
            double sum = 0;

            foreach (double number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        public static double Subtraction(double[] numbers)
        {
            double difference = numbers[0]; // Adds the first number

            for (int i = 1; i < numbers.Length; i++)
            {
                difference -= numbers[i]; // And subtracts all other numbers
            }

            return difference;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }

        public static double Division(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                return double.NaN;
            }
        }
    }
}
