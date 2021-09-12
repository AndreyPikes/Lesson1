using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork1_Task2;

namespace HomeWork1_Task3
{
    /*Щукин Андрей
        ) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. */
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Input.ReadDouble("Введите X1");
            double y1 = Input.ReadDouble("Введите Y1");
            double x2 = Input.ReadDouble("Введите X2");
            double y2 = Input.ReadDouble("Введите y2");

            Console.WriteLine($"Результат: {Magnitude(x1, y1, x2, y2):#.##}");
            Console.ReadLine();
        }

        static double Magnitude(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
