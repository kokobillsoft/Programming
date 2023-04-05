using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class AgeOfPeople
    {
        public static int Check(int inputAge)
        {
            int answerToReturn = -1;
            if ((inputAge >= 0) && (inputAge <= 122))
            {
                answerToReturn = inputAge;
            }   
            return answerToReturn;
        }
    }
}
