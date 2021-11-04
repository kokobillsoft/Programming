using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class AgeOfPeople
    {
        public static int Check(int inputAge)
        {
            if ((inputAge >= 0) && (inputAge <= 122))
                return inputAge;
            return -1;
        }
    }
}
