using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class AnswerTo
    {
        public static bool WinConsole()
        {
            int answerFromCheking;
            bool answerToReturn = false;
            answerFromCheking = CheckWord.PalindromeOrNotPalindrome();
            if (answerFromCheking != -1)
            {
                if (answerFromCheking == 1)
                {
                    Console.WriteLine("+++++Word is a palindrom+++++");
                    answerToReturn = true;
                }
                else
                {
                    Console.WriteLine("+++++Word is not a palindrom+++++");
                    answerToReturn = true;
                } 
            }
            return answerToReturn;
        }
    }
}
