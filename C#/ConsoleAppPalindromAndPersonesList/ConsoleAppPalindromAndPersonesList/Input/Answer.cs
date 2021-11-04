using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Answer
    {
        public static bool AnswerFromConsoleYOrN()
        {
            int wrongAnswerCount = 0;
            string answerYN;
            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Enter Y=\"Yes\" or N=\"No\"*****");
                answerYN = Console.ReadLine();
                if (answerYN == "N")
                {
                    return false;
                }
                else if (answerYN == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("-----Your answer wrong!-----");
                    wrongAnswerCount++;
                }
            }
            Console.ReadLine();
            return false;
        }
    }
}
