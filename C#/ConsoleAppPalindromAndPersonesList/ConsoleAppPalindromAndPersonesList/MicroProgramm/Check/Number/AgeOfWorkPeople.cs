using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class AgeOfWorkPeople
    {
        public static int Check(int inputAge)
        {
            int answerForReturn = -1;
            if (AgeOfPeople.Check(inputAge) != -1)
            {
                if (inputAge >= 18)
                {
                    answerForReturn = inputAge;
                }     
            }
            return answerForReturn;
        }
    }
}
