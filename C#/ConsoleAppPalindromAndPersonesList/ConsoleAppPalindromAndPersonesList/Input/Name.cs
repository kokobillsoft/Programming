using System;
namespace ConsoleAppPalindromAndPersonesList.Input
{
    public class Name
    {
        public static string FromConsole()
        {
            int wrongAnswerCount = 0;
            string nameFromConsole,formatingName;
            Console.WriteLine("*****Enter Name*****");
            while (wrongAnswerCount < 5)
            {
                nameFromConsole = Input.Word.LatinFromConsole();
                if (nameFromConsole == null)
                {
                    return null;
                }
                formatingName = MicroProgramm.Check.Word.LatinName.CheckAndConwerting(nameFromConsole);
                if (formatingName != null)
                {
                    return(formatingName);
                }
                else
                {
                    wrongAnswerCount++;
                    Console.WriteLine("-----Name must have 2 or more letters-----");
                }
            }
            return null;
        }
    }
}
