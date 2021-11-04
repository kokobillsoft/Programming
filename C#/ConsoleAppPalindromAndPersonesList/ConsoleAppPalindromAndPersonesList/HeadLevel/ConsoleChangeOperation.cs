using System;
namespace ConsoleAppPalindromAndPersonesList.HeadLevel
{
        public class ConsoleChangeOperation
        {
            public static bool ChangeOperation()
            {
                string curentChangeOperation;
                int wrongAnswerCount = 0;
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
                            return true;
                        
                        case "1":
                            if (!MicroProgramm.Check.Palindrome.AnswerTo.WinConsole())
                            {
                                Console.WriteLine("-----Palindrome word check failed-----");
                            }
                            Console.WriteLine("+++++Palindrome word check complited+++++");
                            wrongAnswerCount = 0;
                            break;

                        case "2":
                            var newPersonesList = MicroProgramm.Create.Listes.Persones.ListPersoneNameAgeID.Create();
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
                return false;
            }
        }
}
