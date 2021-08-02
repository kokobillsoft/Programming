using System;
using System.Collections.Generic;

namespace test01082021
{
    public class Person
    {
        public int indexOfPerson;
        public int ageOfPerson;
        public string nameOfPerson;
    };
    class MainClass
    {

        public static void createPersoneList(List<Person> newPerson)
        {

            newPerson.Add(new Person());
            newPerson[newPerson.Count-1].indexOfPerson = 24;
            Console.WriteLine("Enter Name of Person");
            newPerson[newPerson.Count - 1].nameOfPerson = Console.ReadLine();
            Console.WriteLine($"Enter index of {newPerson[newPerson.Count - 1].nameOfPerson} ");
            newPerson[newPerson.Count - 1].indexOfPerson = Int32.Parse (Console.ReadLine());
            Console.WriteLine($"Enter age of {newPerson[newPerson.Count - 1].nameOfPerson} with index:{newPerson[newPerson.Count - 1].indexOfPerson}");
            newPerson[newPerson.Count - 1].ageOfPerson = Int32.Parse(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            bool markEndReadingData = true;

            List<Person> listOfNames = new List<Person>();
            Console.WriteLine("Please, enter data of person (Name, index, age");
            while (markEndReadingData)
            {
                createPersoneList (listOfNames);
                Console.WriteLine("Add new person? Y/N");
                bool markAnswerAddNewPerson = true;
                while (markAnswerAddNewPerson)
                {
                    string consoleAnswerAddNewPerson = Console.ReadLine();
                    if (consoleAnswerAddNewPerson == "N")
                    {
                        markEndReadingData = false;
                        markAnswerAddNewPerson = false;

                    }
                    else if (consoleAnswerAddNewPerson != "Y")
                    {
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("Add new person? Y/N");
                    }
                    else
                    {
                        markAnswerAddNewPerson = false;
                    }
                }
            }
            bool markAnswerWriteAllList = true;
            Console.WriteLine("Write all List? Y/N");
            string consoleAnswerWriteAllList = Console.ReadLine();
            while(markAnswerWriteAllList)
            {
                if (consoleAnswerWriteAllList == "N")
                {
                    Console.WriteLine("GoodWork!");
                    markAnswerWriteAllList = false;
                }
                else if (consoleAnswerWriteAllList != "Y")
                {
                    Console.WriteLine("Wrong answer.");
                    Console.WriteLine("Write all List? Y/N");
                }
                else
                {
                    Console.WriteLine("******************");
                    for (int i = 0; i < listOfNames.Count; i++)
                    {
                        
                        Console.WriteLine($"{listOfNames[i].nameOfPerson} index: {listOfNames[i].indexOfPerson}  age: {listOfNames[i].ageOfPerson}");
                        
                    }
                    Console.WriteLine("******************");
                    Console.WriteLine("GoodWork!");
                    markAnswerWriteAllList = false;

                }
            }
        }
            
    }
}
