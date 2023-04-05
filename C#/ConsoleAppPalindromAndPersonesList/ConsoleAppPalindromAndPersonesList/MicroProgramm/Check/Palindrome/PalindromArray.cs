using System;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class PalindromArray
    {
        public static bool Checking(char[] checkArray)
        {
            bool answerToReturn = true;
            for (int i = 0; i < (checkArray.Length / 2); i++)
            {
                if (checkArray[i] != checkArray[checkArray.Length - 1 - i])
                {
                    answerToReturn = false;
                }
            }
            return answerToReturn;
        }
    }
}
