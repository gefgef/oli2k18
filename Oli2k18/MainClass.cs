using System;

namespace Oli2k18
{
    class MainClass
    {
        static void Main()
        {
            //1. Equation
            string filename = "equation";
            string completeEquation = Equation.getEquation(IO.readNumbersFromFileToArrayOneLine(filename));
            IO.writeStringToFile(completeEquation, filename);
            


        }


    }
}
