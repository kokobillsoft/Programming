using System;
namespace PersonList.Input
{
    public class InputAge
    {
        public static int FromConsole()
        {
            int age;
            bool counterOutFromCycle = true;
            int counterOfWrongAnswer = 0;

            while (counterOutFromCycle && counterOfWrongAnswer < 5)
            {

                age = Input.Number.FromConsoleUnsignedInt();
                if ((age>0) || (age<130))
                {
                    return age;
                }
                counterOfWrongAnswer++;
            }
            return -1;
        }
    }
}
