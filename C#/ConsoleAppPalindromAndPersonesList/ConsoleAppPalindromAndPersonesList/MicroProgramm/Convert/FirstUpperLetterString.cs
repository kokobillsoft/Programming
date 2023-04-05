using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Convert
{
    public class FirstUpperLetterString
    {
        public static string Converting(string stringWithoutConverting)
        {
            string convertingString = null;
            char[] convertingStringCharArray;
            bool firstLetterIsLower = true;

            if (!String.IsNullOrEmpty(stringWithoutConverting))
            {
                convertingStringCharArray = stringWithoutConverting.ToCharArray();
                for (int i = 0; i < convertingStringCharArray.Length; i++)
                {
                    if (Char.IsLetter(convertingStringCharArray[i]))
                    {
                        if (firstLetterIsLower)
                        {
                            convertingStringCharArray[i] = Char.ToUpper(convertingStringCharArray[i]);
                            firstLetterIsLower = false;
                        }
                        else
                        {
                            convertingStringCharArray[i] = Char.ToLower(convertingStringCharArray[i]);
                        }
                    }
                }             
                convertingString = new string(convertingStringCharArray);
            }
                return convertingString;
        }
    }
}
