using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	Написать программу для нахождения факториала числа n.
            Console.WriteLine("Введи число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int v = 1;
            for (int i = 1; i <= n; i++)
            {
                v = v * i;
            }
            Console.WriteLine("Ответ" + v);
            Console.ReadKey();

        }
    }
}
