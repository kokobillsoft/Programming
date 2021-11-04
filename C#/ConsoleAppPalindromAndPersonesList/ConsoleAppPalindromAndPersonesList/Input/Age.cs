using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Age
    {
        public static int FromConsole()
        {
            int wrongAnswerCount = 0;
            int ageFromConsole, numberFromConsole;

            
            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Enter the workrer's age*****");
                numberFromConsole = Input.Number.IntFromConsole();
                if (numberFromConsole == -2147483648)
                {
                    return -1;
                }
                if (MicroProgramm.Check.Number.AgeOfWorkPeople.Check(numberFromConsole) != -1)
                {
                    return numberFromConsole;
                }
                Console.WriteLine("-----Input ERROR!-----");
                wrongAnswerCount++;
            }
                return -1;
        }
    }
}
