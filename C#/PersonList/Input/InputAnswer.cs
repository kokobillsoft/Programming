using System;
namespace PersonList.Input
{
    public class Answer
    {
        public static bool FromConsoleYOrN()
        {
            bool flagOutFromCycle = true;
            string answerFromConsole;
            int counterOfWrongAnswer = 0;

            while (flagOutFromCycle && (counterOfWrongAnswer<5))
            {
                answerFromConsole = Console.ReadLine();
                if (answerFromConsole == "Y")
                    return true;
                else if (answerFromConsole == "N")
                    return false;
                else
                {
                    Console.WriteLine("You must enter Y - for approve, or enter N - for decline");
                    counterOfWrongAnswer++;
                }
            }
            return false;
          
        }
    }
}
