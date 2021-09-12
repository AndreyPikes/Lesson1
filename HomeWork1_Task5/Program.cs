using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Task5
{
    /*Щукин Андрей
        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. б) Сделать задание, только вывод организовать в центре экрана.
в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y). */

    class Program
    {
        static void Main(string[] args)
        {
            PrintText("Андрей");
            PrintText("Щукин");
            PrintText("Москва");

            Console.ReadLine();
        }

        static void PrintText(string text)
        {
            int positionX = Console.WindowWidth / 2 - text.Length / 2;
            int positionY = Console.CursorTop == 0 ? Console.WindowHeight / 2 : Console.CursorTop + 1;

            Console.SetCursorPosition(positionX, positionY);

            Console.Write(text);
        }
    }
}
