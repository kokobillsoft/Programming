using System;
using System.Collections.Generic;

namespace PersonList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var newList = CreateList.CreatePersonesList();
            Output.ConsoleWriteList.ConsoleWriteListOfPersones(newList);
        }
    }
}
