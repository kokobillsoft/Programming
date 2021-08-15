using System;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;

namespace PersonList.Input
{
    public class Number
    {
        public static int FromConsoleUnsignedInt()
        {
            bool counterOutFromCycle = true;
            int counterOfWrongAnswer = 0;
            string newString;

            while (counterOutFromCycle && counterOfWrongAnswer < 5)
            {
                newString = Console.ReadLine();
                if (!String.IsNullOrEmpty(newString) && Regex.IsMatch(newString, @"^[0-9]+$")) //The number must consist only numbers
                    return Convert.ToInt32(newString);
                Console.WriteLine("Number is wrong! Use only numbers 0-9");
                counterOfWrongAnswer++;
            }
            return -1; // mark of alarm input
        }
    }
}
