using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint5.Task0.V30.Lib;

namespace Tyuiu.ChebulaevAG.Sprint5.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                        *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("* y(x) = (x ^ 2 + 1)/(3x + 4)                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
