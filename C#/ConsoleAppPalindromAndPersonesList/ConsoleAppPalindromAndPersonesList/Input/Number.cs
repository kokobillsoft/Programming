using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Number
    {
        public static int IntFromConsole()
        {
            int intFromConsole, wrongAnswerCount=0;
            string inputNumberFromConsoleInString;

            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Use only 0-9 and, without letter or other special symbol!*****");
                inputNumberFromConsoleInString = Console.ReadLine();
                if (MicroProgramm.Check.Number.IntegerYOrN.Check(inputNumberFromConsoleInString))
                {
                    intFromConsole = Int32.Parse(inputNumberFromConsoleInString);
                    return intFromConsole;
                }
                Console.WriteLine("-----Input ERROR!-----");
                wrongAnswerCount++;
            }
            return -2147483648;
        }
    }
}
