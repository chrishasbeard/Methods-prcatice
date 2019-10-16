using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Grant Chirpus");
            GreetUser("hockey", "Wayne of Letterkenny");
        }
        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public static void GreetUser(string language, string name)
        {
            switch(language)
            {
                case "french":
                    Console.WriteLine($"Bonjour, {name}");
                    break;
                case "german":
                    Console.WriteLine($"Guten Tag, {name}");
                    break;
                case "spanish":
                    Console.WriteLine($"Hola, {name}");
                    break;
                case "hockey":
                    Console.WriteLine($"Wheel, Snipe, Celly {name}");
                    break;
                case "latin":
                    Console.WriteLine($"Salve, {name}");
                    break;
            }
        }

    }
}
