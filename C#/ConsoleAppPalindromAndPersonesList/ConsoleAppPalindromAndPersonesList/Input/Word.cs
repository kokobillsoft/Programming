using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Word
    {
        public static string LatinFromConsole()
        {
            string wordFromConsole = null;
            int counterOfWrongAnswer = 0;

            while (counterOfWrongAnswer < 5)
            {
                Console.WriteLine("*****Use only latin alphabet, without number or special symbol!*****");
                wordFromConsole = Console.ReadLine();
                if (!Latin.TrueORFalse(wordFromConsole))
                {
                    Console.WriteLine("-----Input ERROR!-----");
                    counterOfWrongAnswer++;
                    wordFromConsole = null;
                }
                else
                {
                    break;
                }

            }
            return wordFromConsole;
        }
    }
}
