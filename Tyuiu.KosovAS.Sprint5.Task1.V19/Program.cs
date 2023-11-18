using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.KosovAS.Sprint5.Task1.V19.Lib;

namespace Tyuiu.KosovAS.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #5 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #5" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #19" + String.Concat(Enumerable.Repeat(" ", 61)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая вычисляет данные по формуле, сохраняет файл  *");
            Console.WriteLine("* и печатает их на экран.                                                 *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            string result = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {result}");
            Console.WriteLine("Создан!");

            string[] values = File.ReadAllLines(result);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            int len = values.Length;

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", startValue, values[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
