using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word
{
    public class LatinName
    {
        public static string CheckAndConwerting(string nameToCheck)
        {
            string convertingName;
            if (MicroProgramm.Check.Word.Latin.TrueORFalse(nameToCheck) && (nameToCheck.Length > 1))
            {
                convertingName = MicroProgramm.Convert.FirstUpperLetterString.Converting(nameToCheck);
                if (convertingName != null)
                {
                    return convertingName;
                }
            }
            return null;
        }
    }
}
