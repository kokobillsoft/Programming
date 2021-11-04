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
                return null;
            newPerson.NameOfPerson = Input.Name.FromConsole();
            if (newPerson.NameOfPerson == null)
                return null;
            newPerson.AgeOfPerson = Input.Age.FromConsole();
            if (newPerson.AgeOfPerson == -1)
                return null;

            return newPerson;
        }
    }
}
