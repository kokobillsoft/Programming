/* Class for input Name from console*/

using System;
using System.Text.RegularExpressions;

namespace PersonList.Input
{
    public class Name
    {
        public static string FromConsole()
        {
            string newString;
            bool counterOutFromCycle = true;
            int counterOfWrongAnswer=0;

            while (counterOutFromCycle && (counterOfWrongAnswer<5)) //If the user enters an invalid name 5 times, the input is terminated 
            {
                newString = Console.ReadLine();
                if (!String.IsNullOrEmpty(newString) && Regex.IsMatch(newString, @"^[a-zA-Z]+$")) //The name must consist of letters of the Latin alphabet
                {
                    return newString;
                }
                    
                Console.WriteLine("Name is wrong! Use only letters of the Latin alphabet");
                counterOfWrongAnswer++;
            }
            return "Name has not been entered";
        }
    }
}
