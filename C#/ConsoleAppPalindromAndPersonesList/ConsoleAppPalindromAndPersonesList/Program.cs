using System;

namespace ConsoleAppPalindromAndPersonesList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (!HeadLevel.ConsoleChangeOperation.ChangeOperation())
            {
                Console.WriteLine("\n\nWork with app is completed with ERROR");
            }
            else
            {
                Console.WriteLine("\n\nWork with app is completed");
            }
            
        }
    }
}
