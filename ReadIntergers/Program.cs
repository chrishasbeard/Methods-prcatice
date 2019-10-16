using System;

namespace ReadIntergers
{
    class Program
    {
        static void Main(string[] args)
        {
            int age  = ReadIntergers("How Old Are You?");
            int year = ReadIntergers("What Year Were You Born?");
            Console.WriteLine($"Your were born in {year} and you're {age} years old.");
        }

        public static int ReadIntergers(string message)
        {
            Console.WriteLine(message);
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
    }
}
