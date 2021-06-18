using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.	Дано натуральное число. Определить его максимальную цифру.
            Console.WriteLine("Введи число");
            int x = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            while (x != 0)
            {
                int a = x % 10;
                if (max < a)
                {
                    max = a;
                }
                x = x / 10;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
