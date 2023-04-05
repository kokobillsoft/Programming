using System;
namespace ConsoleAppPalindromAndPersonesList.MicroProgramm.Create.Listes.Persones
{
    public class NewPersonNameAgeID
    {
        public static PersoneNameAgeID FromConsole()
        {
            var newPerson = new PersoneNameAgeID();

            newPerson.IndexOfPerson = Input.ID.FromConsole();
            if (newPerson.IndexOfPerson == -1)
            {
                newPerson = null;
            }
            else
            {
                newPerson.NameOfPerson = Input.Name.FromConsole();
                if (newPerson.NameOfPerson == null)
                {
                    newPerson = null;
                }
                else
                {
                    newPerson.AgeOfPerson = Input.Age.FromConsole();
                    if (newPerson.AgeOfPerson == -1)
                    {
                        newPerson = null;
                    }
                }
            }
            return newPerson;
        }
    }
}
