using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Number
    {
        public static int IntFromConsole()
        {
            int intFromConsole = -2147483648;
            int wrongAnswerCount=0;
            string inputNumberFromConsoleInString;

            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Use only 0-9 and, without letter or other special symbol!*****");
                inputNumberFromConsoleInString = Console.ReadLine();
                if (IntegerYOrN.Check(inputNumberFromConsoleInString))
                {
                    intFromConsole = Int32.Parse(inputNumberFromConsoleInString);
                    break;
                }
                Console.WriteLine("-----Input ERROR!-----");
                wrongAnswerCount++;
            }
            return intFromConsole;
        }
    }
}
