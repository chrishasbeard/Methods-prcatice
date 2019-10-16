using System;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = CalculateSumRecursively(1, 5);
            Console.WriteLine($"Expected: 15 and my actual: {sum}");
        }
        public static int CalculateSumRecursively(int number1, int number2)
        {
            int sum = number1;
            if(number1<number2)
            {
                number1++;
                sum = sum + CalculateSumRecursively(number1, number2);
                return sum;
            }
            return sum;
        }
    }
}
