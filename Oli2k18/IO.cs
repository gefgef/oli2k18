using System;
using System.IO;
using System.Linq;

namespace Oli2k18
{
    class IO
    {

        const string relativePath = "../../files/";
        
        public static int[] readNumbersFromFileToArrayOneLine(string filename)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(relativePath + filename + ".in", FileMode.Open, FileAccess.Read);
            } catch (IOException exc)
            {
                Console.WriteLine("IO error: " + exc.Message);
            }

            StreamReader strRdr = new StreamReader(file);
            string str = "";
            try
            {
                str = strRdr.ReadLine();
            } catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc);
            } finally
            {
                file.Close();
            }
            return stringToArray(str);
        }

        public static void writeStringToFile(string text, string filename)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(relativePath + filename + ".out", FileMode.Create, FileAccess.Write);
            }
            catch (IOException exc)
            {
                Console.WriteLine("IO error: " + exc.Message);
            }

            using (StreamWriter strWrt = new StreamWriter(file, System.Text.Encoding.Default))
            {
                strWrt.Write(text);
            }
        }

        public static int[] stringToArray(string str)
        {
            int[] numbers = new int[str.Length];
            string nextNumber = "";
            int index = 0;

            foreach (char i in str + " ")
            {
                int j;
                if (int.TryParse(i.ToString(), out j))
                {
                    nextNumber = nextNumber + j;
                }
                else
                {
                    numbers[index] = int.Parse(nextNumber);
                    index++;
                    nextNumber = "";
                }
            }
            numbers = Array.FindAll(numbers, isNotNull).ToArray();
            return numbers;
        }

        private static bool isNotNull(int n)
        {
            return n != 0;
        }

        public static void printArray(int[] array)
        {
            foreach (int i in array)
                Console.Write(i);
        }
    }
}
