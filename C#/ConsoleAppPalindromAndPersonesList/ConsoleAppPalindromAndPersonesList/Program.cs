using System;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Check.Palindrome;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Create.Listes.Persones;

namespace ConsoleAppPalindromAndPersonesList
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string curentChangeOperation;
            int wrongAnswerCount = 0;
            bool statusErrorWorkProgramm = true ;

            Console.WriteLine("*****Do yo want begin \"Palindrom check\" or \"Create perones list\"?*****");
            // Console.WriteLine(Input.Answer.AnswerFromConsoleYOrN());
            if (Input.Answer.AnswerFromConsoleYOrN())
            {
                while (wrongAnswerCount < 5)
                {
                    Console.WriteLine("*****Change action. Enter key for continue*****\n" +
                     "Palindrom check - \"1\"\n" +
                     "Create persones list - \"2\"\n" +
                     "End programm - \"0\"\n");
                    curentChangeOperation = Console.ReadLine();
                    switch (curentChangeOperation)
                    {
                        case "0":
                            statusErrorWorkProgramm = true;
                            break;

                        case "1":
                            if (!AnswerTo.WinConsole())
                            {
                                Console.WriteLine("-----Palindrome word check failed-----");
                            }
                            Console.WriteLine("+++++Palindrome word check complited+++++");
                            wrongAnswerCount = 0;
                            break;

                        case "2":
                            var newPersonesList = ListPersoneNameAgeID.Create();
                            if (newPersonesList == null)
                            {
                                Console.WriteLine("-----Persones List don't created-----");
                            }
                            else
                            {
                                Console.WriteLine("+++++Persones List created+++++\n ******Do you want" +
                                    "to output the List to the console******");
                                if (Input.Answer.AnswerFromConsoleYOrN())
                                {
                                    Output.OutputListPersonesNameAgeID.ToConsole(newPersonesList);
                                }
                            }
                            wrongAnswerCount = 0;
                            break;

                        default:
                            Console.WriteLine("-----Your answer wrong-----");
                            wrongAnswerCount++;
                            break;

                    }

                }

            }
            else
            {
                statusErrorWorkProgramm = false;
            }
            if (!statusErrorWorkProgramm)
            {
                Console.WriteLine("\n\nWork with app is completed with ERROR");
            }
            else
            {
                Console.WriteLine("\n\nWork with app is completed");
            }
            
        }
    }
}
