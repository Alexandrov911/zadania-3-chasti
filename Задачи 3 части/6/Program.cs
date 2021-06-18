using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Дано натуральное число. Определить его минимальную цифру.
            Console.WriteLine("Введи число");
            int x = Convert.ToInt32(Console.ReadLine());
            int min = 10;
            while (x != 0)
            {
                int a = x % 10;
                if (min > a)
                {
                    min = a;
                }
                x = x / 10;
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
