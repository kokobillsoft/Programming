using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Convert;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word
{
    public class LatinName
    {
        public static string CheckAndConwerting(string nameToCheck)
        {
            string convertingName = null;

            if (Latin.TrueORFalse(nameToCheck) && (nameToCheck.Length > 1))
            {
                convertingName = FirstUpperLetterString.Converting(nameToCheck);
            }
            return convertingName;
        }
    }
}
