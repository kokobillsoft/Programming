using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Answer
    {
        public static bool AnswerFromConsoleYOrN()
        {
            int wrongAnswerCount = 0;
            string answerYN;
            bool answerToReturn = false;
            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Enter Y=\"Yes\" or N=\"No\"*****");
                answerYN = Console.ReadLine();
                if (answerYN == "N")
                {
                    answerToReturn = false;
                    break;
                }
                else if (answerYN == "Y")
                {
                    answerToReturn = true;
                    break;
                }
                else
                {
                    Console.WriteLine("-----Your answer wrong!-----");
                    wrongAnswerCount++;
                }
            }
            return answerToReturn;
        }
    }
}
