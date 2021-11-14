using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class CheckWord
    {
        public static int PalindromeOrNotPalindrome() //Answer "0"-false,"1"-true, "-1"-Error
        {
            string checkWord;
            string checkWordToLower;
            char[] checkWordArrayOfChar;
            int answerToReturn = 0;
            checkWord = Input.Word.LatinFromConsole();
            if (checkWord == null)
            {
                answerToReturn = -1;
            }
            else
            {
                checkWordToLower = checkWord.ToLower();
                checkWordArrayOfChar = checkWordToLower.ToCharArray();
                if (PalindromArray.Checking(checkWordArrayOfChar))
                {
                    answerToReturn = 1;
                }
            }
            return answerToReturn;
        }
    }
}
