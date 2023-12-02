using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint5.Review.V14.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Review.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V14.txt в котором есть         *");
            Console.WriteLine("* набор символьных данных.Сделать все латинские буквы из файла заглавными. *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V14.txt.        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V14.txt";
            string pathsave = $@"C:\Users\yarik\source\repos\Tyuiu.IvanovSI.Sprint5.Review\Tyuiu.IvanovSI.Sprint5.Review.V14\bin\Debug\OutPutDataFileTask7V14.txt";
            Console.WriteLine("Данные в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            pathsave = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат находится в файле: " + pathsave);
            Console.ReadKey();
        }
    }
}
