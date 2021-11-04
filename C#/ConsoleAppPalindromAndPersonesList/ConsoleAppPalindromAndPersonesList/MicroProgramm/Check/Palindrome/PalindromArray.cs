using System;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome
{
    public class PalindromArray
    {
        public static bool Checking(char[] checkArray)
        {
            for (int i = 0; i < (checkArray.Length / 2); i++)
            {
                if (checkArray[i] != checkArray[checkArray.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
