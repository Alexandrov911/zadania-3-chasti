using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Найти среднее арифметическое всех целых чисел от a до b.
            Console.WriteLine("Введи число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int v = 0;
            for (int i = a; i <= b; i++)
            {
                v = v + i;
            }
            int m = b - a + 1;
            double c = 1.0 * v / m;
            Console.WriteLine("Ответ" + c);
            Console.ReadKey();
        }
    }
}
