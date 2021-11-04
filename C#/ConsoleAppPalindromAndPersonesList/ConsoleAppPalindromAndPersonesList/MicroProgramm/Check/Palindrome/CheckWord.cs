using System;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class CheckWord
    {
        public static int PalindromeOrNotPalindrome() //Answer "0"-false,"1"-true, "-1"-Error
        {
            string checkWord;
            char[] checkWordArrayOfChar;
            checkWord = Input.Word.LatinFromConsole();
            if (checkWord == null)
            {
                return -1;
            }
            checkWordArrayOfChar = checkWord.ToCharArray();
            if (MicroProgramm.Check.Palindrome.PalindromArray.Checking(checkWordArrayOfChar))
            {
                return 1;
            }
            return 0;
        }
    }
}
