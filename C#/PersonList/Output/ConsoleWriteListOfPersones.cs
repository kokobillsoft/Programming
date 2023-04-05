using System;
using System.Collections.Generic;

namespace PersonList.Output
{
    public class ConsoleWriteList
    {
        public static void ConsoleWriteListOfPersones(List <Person> printList)
        {
            for (int i=0; i<printList.Count; i++)
            {
                Console.WriteLine($"Person ID: {printList[i].IndexOfPerson} | Person Name: {printList[i].NameOfPerson}" +
                    $" | Person age: {printList[i].AgeOfPerson}");
      
            }
        }
    }
}
