using System;
using System.Collections;
namespace Day_1
{
    class Program
    {
        private static int finalResult = 0;
        private static int neededFuel = 0;
        private static int task = 1;
        static void Main(string[] args)
        {
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"input.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (task == 1)
                {
                    neededFuel += singleModule(Convert.ToInt32(line));
                }
                else
                {
                    finalResult = 0;
                    countFuel(Convert.ToInt32(line));
                    neededFuel += finalResult;
                }
            }
            Console.WriteLine(neededFuel);
        }

        private static void countFuel(int mass)
        {

            int result = ((mass / 3) - 2);
            if (result > 0)
            {
                finalResult += result;
                countFuel(result);
            }
            else
            {
                return;
            }
        }
        private static int singleModule(int mass)
        {
            return Convert.ToInt32(Math.Floor(Convert.ToDouble(mass) / 3.0) - 2);
        }
    }
}
