using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class IntegerYOrN
    {
        public static bool Check(string inputSting)
        {
            char[] inputStringCharArray;
            if (!String.IsNullOrEmpty(inputSting))
            {
                inputStringCharArray = inputSting.ToCharArray();
                if (inputStringCharArray[0] == '-' || Char.IsDigit(inputStringCharArray[0]))
                {
                    for (int i = 1; i < inputSting.Length; i++)
                    {
                        if (!Char.IsDigit(inputStringCharArray[i]))
                            return false;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
