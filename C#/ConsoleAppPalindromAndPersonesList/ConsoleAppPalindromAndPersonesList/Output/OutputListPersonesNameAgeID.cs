using System;
using System.Collections.Generic;
using ConsoleAppPalindromAndPersonesList.MicroProgramm.Create.Listes.Persones;

namespace ConsoleAppPalindromAndPersonesList.Output
{
    public class OutputListPersonesNameAgeID
    {
        public static void ToConsole(List<PersoneNameAgeID> printList)
        {
            foreach (PersoneNameAgeID element in printList)
            {
                Console.WriteLine($"Person ID: {element.IndexOfPerson} | Person Name: {element.NameOfPerson}" +
                    $" | Person age: {element.AgeOfPerson}");
            }
            
        }
    }
}
