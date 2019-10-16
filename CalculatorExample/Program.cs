using System;

namespace CalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GC calculator!");
            //TO DO: write method for retrieving user number
            decimal number1 = GetUserNumber();
            decimal number2;
            bool keepGoing = true;
            while (keepGoing) 
            {
                PrintMenu();

                string operation = Console.ReadLine();
                switch(operation)
                {
                    case "1":
                    case "Addition":
                        // TO DO:addition method
                        number2 = GetUserNumber();
                        number1 = AddNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");
                        break;
                    case "2":
                    case "Subraction":
                        //TO DO: subtraction
                        number2 = GetUserNumber();
                        number1 = SubtractNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");

                        break;
                    case "3":
                    case "Multiplication":
                        //TO DO: multiplication
                        number2 = GetUserNumber();
                        number1 = MultiplyNumber(number1, number2);
                        Console.WriteLine($"Result: {number1}");

                        break;
                    case "4":
                    case "Division":
                        //TO DO: Division
                        number2 = GetUserNumber();
                        number1 = DivideNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");

                        break;
                    case "5":
                    case "Percentage":
                        //write percentage method
                        number1 = PercentNumbers(number1);
                        Console.WriteLine($"Result: {number1} %");

                        break;
                    case "6":
                    case "Clear":
                        number1 = GetUserNumber();
                        break;

                    case "7":
                    case "Exit":
                        //TO DO: exit
                        keepGoing = false;
                        break;



                }
            }
        }
        public static void PrintMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Clear");
            Console.WriteLine("7. Exit");
        }

        //TO DO: Write GetUserNumber method
        public static decimal GetUserNumber()
        {
            string input = Console.ReadLine();
            decimal number = decimal.Parse(input);
            return number;
            //return decimal.Parse(Console.ReadLine()); <---condensed shortcut way to write this method
        }
        public static decimal AddNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 + number2;
            return sum;
        }
        public static decimal SubtractNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 - number2;
            return sum;
        }
        public static decimal MultiplyNumber(decimal number1, decimal number2)
        {
            decimal sum = number1 * number2;
            return sum;
        }
        public static decimal DivideNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 / number2;
            return sum;
        }
        public static decimal PercentNumbers(decimal number1)
        {
            decimal sum = number1 / 100;
            return sum;
        }
    }
}
