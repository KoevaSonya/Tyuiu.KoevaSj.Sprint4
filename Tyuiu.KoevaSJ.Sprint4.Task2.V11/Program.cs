using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint4.Task2.V11.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task2.V11
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
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #11                                                                   *");
            Console.WriteLine("* Выполнил: Коева Софья Юрьевна | АСОиУб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный значениями   *");
            Console.WriteLine("* в диапазоне от 3 до 8 подсчитать cумму четных элементов массива*       ");
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
