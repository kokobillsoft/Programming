using System;
using System.Collections.Generic;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Create.Listes.Persones
{
    public class ListPersoneNameAgeID
    {
        public static List<PersoneNameAgeID> Create()
        {
            var newPersonesList = new List<PersoneNameAgeID>();
            var newPersone = new PersoneNameAgeID();

            Console.WriteLine("*****Do You want create new person?*****");
            while (Input.Answer.AnswerFromConsoleYOrN())
            {
                newPersone = NewPersonNameAgeID.FromConsole();
                if (newPersone == null)
                {
                    Console.WriteLine("-----New Persone dont created-----");
                }
                else
                {
                    Console.WriteLine("+++++New Persone created+++++");
                    newPersonesList.Add(newPersone);
                }
                Console.WriteLine("*****Do You want create new person?  Y/N*****");
            }
            if (newPersonesList.Count == 0)
            {
                newPersonesList = null;
            }    
            return newPersonesList;
        }
    }
}
