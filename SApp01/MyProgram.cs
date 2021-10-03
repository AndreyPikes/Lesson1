using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SApp01
{
    class MyProgram
    {


        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Дополнительные параметры</param>
        static void Main(string[] args)
        {
            
            #region Вывод информации
            
            // Вывод информации на консоль
            Console.WriteLine("Hello World!");

            // Еще один вывод на консоль
            System.Console.WriteLine(22);


            #endregion


            #region Задача 1

            Console.Title = "Сумма чисел";
            Console.Clear();

            // short
            // int
            // long

            int number1;
            int number2 = 10;

            Int32 num = 5;
            int num1 = 5;


            long b = 5;
            short a = 15;

            bool Flag = true;
            bool flag = false;
            bool FlaG = true;
            bool flag2 = false;

            string str01 = "Hello";

            Console.WriteLine("Введите первое число:");
            string input01 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string input02 = Console.ReadLine();

            number1 = int.Parse(input01);
            number2 = Convert.ToInt32(input02);

            // * / +  - %

            int number3 = number1 + number2;
            Console.WriteLine("Число " + number1 +  " + число " + number2 +  " = " + number3);
            Console.WriteLine("Число {0} + число {1} = {2}", number1, number2, number3);
            Console.WriteLine($"Число {number1} + число {number2} = {number3}");
            Console.WriteLine("Hello");
            Console.WriteLine($"Число {{number1}} {number1}");

            Console.ReadLine();
            #endregion

            #region Задача 2

            Console.Title = "Четность числа";
            Console.Clear();

            Console.WriteLine("Введите число для проверки:");
            string input03 = Console.ReadLine();
            int number4 = int.Parse(input03);
            bool res = IsEven(number4);
            Console.WriteLine($"Четность числа : {res}");

            #endregion

            #region Задача 3
            #endregion


            /*
             
                Ввод данных на
                консоль
             
             */
            Console.ReadLine();
        }

        static bool IsEven(int num)
        {
            // < > == != >= <=
            bool f = num % 2 == 0;

            return f;

        }
    }
}
