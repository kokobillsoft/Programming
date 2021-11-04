using System;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class AnswerTo
    {
        public static bool WinConsole()
        {
            int answerFromCheking;
            answerFromCheking = MicroProgramm.Check.Palindrome.CheckWord.PalindromeOrNotPalindrome();
            if (answerFromCheking != -1)
            {
                if (answerFromCheking == 1)
                {
                    Console.WriteLine("+++++Word is a palindrom+++++");
                    return true;
                }
                Console.WriteLine("+++++Word is not a palindrom+++++");
                return true;
            }
            return false;
        }
    }
}
