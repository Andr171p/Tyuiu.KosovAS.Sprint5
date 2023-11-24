﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint5.Task5.V28.Lib;

namespace Tyuiu.KosovAS.Sprint5.Task5.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #5" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Класс File. Чтение набора данных из текстового файла              *");
            Console.WriteLine("* Задание #5" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #28" + String.Concat(Enumerable.Repeat(" ", 61)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая вычисляет данные по формуле, сохраняет файл  *");
            Console.WriteLine("* и печатает их на экран.                                                 *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint5\DataSprint5\Sprint5Task5\InPutDataFileTask5V28.txt";

            Console.WriteLine($"Данные нахлдяться в файле: {path}");

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Факториал наименьшего положительного числа делящегося на 5:\n{result}");

            Console.ReadKey();
        }
    }
}
