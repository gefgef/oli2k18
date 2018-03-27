using System;

namespace Oli2k18
{
    class Equation
    {

        public static string getEquation(int[] array)
        {
            if (array[0] + array[1] == array[2])
                return array[0] + "+" + array[1] + "=" + array[2];
            if (array[0] - array[1] == array[2])
                return array[0] + "-" + array[1] + "=" + array[2];
            if (array[0] * array[1] == array[2])
                return array[0] + "*" + array[1] + "=" + array[2];
            if (array[0] / array[1] == array[2])
                return array[0] + "/" + array[1] + "=" + array[2];
            if (array[1] + array[2] == array[0])
                return array[0] + "=" + array[1] + "+" + array[2];
            if (array[1] - array[2] == array[0])
                return array[0] + "=" + array[1] + "-" + array[2];
            if (array[1] * array[2] == array[0])
                return array[0] + "=" + array[1] + "*" + array[2];
            if (array[1] / array[2] == array[0])
                return array[0] + "=" + array[1] + "/" + array[2];
            return "wrong input";
        }

    }
}
