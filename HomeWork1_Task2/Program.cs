using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Task2
{
    /* Щукин Андрей
        Ввести вес и рост человека.Рассчитать и вывести индекс массы тела (ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах. */

    class Program
    {
        static void Main(string[] args)
        {
            double mass = Input.ReadDouble("Введите Вашу массу");
            double height = Input.ReadDouble("Введите Ваш рост");

            Console.WriteLine($"Индекс массы тела = {mass / (Math.Pow(height, 2))}");
            Console.ReadLine();
        }
    }
}
