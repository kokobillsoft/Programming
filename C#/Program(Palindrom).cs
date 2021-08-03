using System;
using System.Collections.Generic;

namespace Palindrom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wordFromConsole;
            char[] wordFromConsoleCharArray;
            bool equalMark = true;
            bool markOfWorkingProgramm = true;
            bool markOfNewWordCheck = true;
            Console.WriteLine("Palindrom word check\n");
           while (markOfWorkingProgramm)
            {
                Console.WriteLine("Enter word\n");
                wordFromConsole = Console.ReadLine();
                wordFromConsoleCharArray = wordFromConsole.ToCharArray();

                for (int i = 0; i < (wordFromConsoleCharArray.Length / 2); i++)
                {
                    if (wordFromConsoleCharArray[i] != wordFromConsoleCharArray[wordFromConsoleCharArray.Length - 1 - i])
                    {
                        equalMark = false;
                        break;
                    }
                }

                if (equalMark && (wordFromConsole != null))
                {
                    Console.WriteLine($"Word {wordFromConsole} is Palindrom");
                }
                else
                {
                    Console.WriteLine($"Word {wordFromConsole} is't Palindrom");
                }
                Console.WriteLine("Check new word? Y/N");
                string consoleAnswer = Console.ReadLine();
                if (markOfNewWordCheck)
                {
                    if (consoleAnswer == "N")
                    {
                        Console.WriteLine("GoodWork");
                        markOfWorkingProgramm = false;
                        markOfNewWordCheck = false;
                    }
                    else if (consoleAnswer != "Y")
                    {
                        Console.WriteLine("Wrong answer");
                    }
                }   
            }
        }
    }
}
