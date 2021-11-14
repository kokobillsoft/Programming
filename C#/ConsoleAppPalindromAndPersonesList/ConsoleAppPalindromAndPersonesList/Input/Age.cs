using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Age
    {
        public static int FromConsole()
        {
            int wrongAnswerCount = 0;
            int numberFromConsole;
            int answerToReturn = -1;

            
            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Enter the workrer's age*****");
                numberFromConsole = Input.Number.IntFromConsole();
                if (numberFromConsole == -2147483648)
                {
                    answerToReturn = -1;
                    break;
                }
                else if (AgeOfWorkPeople.Check(numberFromConsole) != -1)
                {
                    answerToReturn = numberFromConsole;
                    break;
                }
                Console.WriteLine("-----Input ERROR!-----");
                wrongAnswerCount++;
            }
                return answerToReturn;
        }
    }
}
