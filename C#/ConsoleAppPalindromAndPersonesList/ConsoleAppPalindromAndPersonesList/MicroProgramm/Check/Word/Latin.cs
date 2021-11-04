using System;
using System.Text.RegularExpressions;

namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word
{
    public class Latin
    {
        public static bool TrueORFalse(string checkWord)
        {
            if (!String.IsNullOrEmpty(checkWord) && Regex.IsMatch(checkWord, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }
    }
}
