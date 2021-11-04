using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Number
{
    public class AgeOfWorkPeople
    {
        public static int Check(int inputAge)
        {
            if (MicroProgramm.Check.Number.AgeOfPeople.Check(inputAge) != -1)
            {
                if (inputAge >= 18)
                    return inputAge;
            }
            return -1;
        }
    }
}
