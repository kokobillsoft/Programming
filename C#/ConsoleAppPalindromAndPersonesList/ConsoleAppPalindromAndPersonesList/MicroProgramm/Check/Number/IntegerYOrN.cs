using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class IntegerYOrN
    {
        public static bool Check(string inputSting)
        {
            bool answerForReturn = false;
            int i=0;
            char[] inputStringCharArray;
            if (!String.IsNullOrEmpty(inputSting))
            {
                inputStringCharArray = inputSting.ToCharArray();
                if (inputStringCharArray[0] == '-' || Char.IsDigit(inputStringCharArray[0]))
                {
                    for (i = 1; i < inputSting.Length; i++)
                    {
                        if (!Char.IsDigit(inputStringCharArray[i]))
                        {
                            answerForReturn = false;
                            break;
                        }
                    }
                    if (i == inputSting.Length)
                    {
                        answerForReturn = true;
                    }
                }
            }
            return answerForReturn;
        }
    }
}
