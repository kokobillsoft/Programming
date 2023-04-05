using System;
using System.Collections.Generic;

namespace PersonList
{
    public class CreateList
    {
        public static List<Person> CreatePersonesList()
        {
            Console.WriteLine("Do You want create persones list?  Y/N");
            if (Input.Answer.FromConsoleYOrN())
            {
                var newPersonesList = new List<Person>();
                Console.WriteLine("Do You want create new person?  Y/N");

                while (Input.Answer.FromConsoleYOrN())
                {
                    newPersonesList.Add(Input.InputPerson.InputPersonFromTerminal());
                    Console.WriteLine("Do You want create new person?  Y/N");
                }

                return newPersonesList;
            }

            return new List<Person>();

        }
        }
}
