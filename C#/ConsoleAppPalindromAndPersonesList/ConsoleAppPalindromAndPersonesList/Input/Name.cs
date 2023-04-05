using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Word;

namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Name
    {
        public static string FromConsole()
        {
            int wrongAnswerCount = 0;
            string nameFromConsole;
            string formatingName = null;

            Console.WriteLine("*****Enter Name*****");
            while (wrongAnswerCount < 5)
            {
                nameFromConsole = Input.Word.LatinFromConsole();
                if (nameFromConsole == null)
                {
                    break;
                }
                formatingName = LatinName.CheckAndConwerting(nameFromConsole);
                if (formatingName != null)
                {
                    break;
                }
                else
                {
                    wrongAnswerCount++;
                    Console.WriteLine("-----Name must have 2 or more letters-----");
                }
            }
            return formatingName;
        }
    }
}
