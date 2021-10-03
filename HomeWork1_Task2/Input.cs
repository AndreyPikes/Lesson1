using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Task2
{
    public static class Input
    {
        public static int ReadInt(string message)
        {
            bool isGoodInput;
            int result;
            do
            {
                Console.WriteLine(message);
                isGoodInput = int.TryParse(Console.ReadLine(), out result);
            } 
            while (!isGoodInput);
            return result;
        }

        public static double ReadDouble(string message)
        {
            bool isGoodInput;
            double result;
            do
            {
                Console.WriteLine(message);
                isGoodInput = double.TryParse(Console.ReadLine(), out result);
            }
            while (!isGoodInput);
            return result;
        }
    }
}
