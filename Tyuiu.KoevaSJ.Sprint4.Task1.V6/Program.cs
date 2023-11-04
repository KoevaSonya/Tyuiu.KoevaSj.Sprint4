using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint4.Task1.V6.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Коева С.Ю. | АСОиУб-23-1 ";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                        *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнил: Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный значениями   *");
            Console.WriteLine("* в диапазоне от 2 до 7 подсчитать произведение четных элементов массива*       ");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int len;
            Console.Write("Введите колличество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] sumArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + "элемента массива: ");
                sumArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(sumArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Сумма четных элементов массива: ");

            int res = ds.Calculate(sumArray);


            Console.Write(res);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
