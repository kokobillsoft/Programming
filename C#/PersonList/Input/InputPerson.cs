using System;
namespace PersonList.Input
{
    public class InputPerson
    {
        public static Person InputPersonFromTerminal()
        {
            string nameCurentPerson;
            int ageCurentPerson;
            int indexCurentPerson;



            
            Console.WriteLine("Enter Name of Person");
            nameCurentPerson = Input.Name.FromConsole();
            if (nameCurentPerson == "Name has not been entered") // Check correct Name
                return new Person();

            Console.WriteLine("Enter Age of Person");
            ageCurentPerson = Input.InputAge.FromConsole();


            Console.WriteLine("Enter ID of Person");
            indexCurentPerson = Input.Number.FromConsoleUnsignedInt(); // Check correct ID
            if (indexCurentPerson < 0) //Check correct Age
                return new Person();

            var newPerson = new Person();
            newPerson.IndexOfPerson = indexCurentPerson;
            newPerson.AgeOfPerson = ageCurentPerson;
            newPerson.NameOfPerson = nameCurentPerson;
            return newPerson;
        }
        
    }
}
