using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class ID
    {
        public static int FromConsole()
        {
            int idFromConsole;
            int wrongAnswerCount = 0;

            while (wrongAnswerCount < 5)
            {
                Console.WriteLine("*****Enter the workrer's ID. Use only 0-9 number*****");
                idFromConsole = Input.Number.IntFromConsole();
                if (idFromConsole > 0)
                {
                    return idFromConsole;
                }
                Console.WriteLine("-----Input ERROR!-----");
                wrongAnswerCount++;
            }
            return -1;
        }
    }
}
