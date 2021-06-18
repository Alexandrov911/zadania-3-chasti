using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_3_части
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Найти сумму квадратов всех целых чисел от a до b(значения a и b вводятся с клавиатуры;
            Console.WriteLine("Введи число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int v = 0;
            for (int i = a; i <= b; i++)
            {
                v = v + i * i;
            }
            Console.WriteLine("Ответ" + v);
            Console.ReadKey();
        }
    
    }
}
