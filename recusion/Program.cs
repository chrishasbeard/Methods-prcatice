using System;

namespace recusion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while(keepGoing)
            {
                //do the things
                //do you want to continue?
                keepGoing = GetContinue();
            }

            Console.WriteLine("Ok, Bye!");
        }

        public static bool GetContinue()
        {
            //input if the want to continue
            Console.WriteLine("Would you like to continue? (y/n)");
            //processing - if y return true, if n return false, if neither call method again
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    return GetContinue();

            }
        }
    }
}
