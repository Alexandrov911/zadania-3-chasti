using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.Одноклеточная амеба каждые 3 часа делится на 2 клетки.Определить, сколько клеток будет через 3,6,9,...,24 часа.
            int sergei = 2;
            for (int i = 3; i <= 24; i = i + 3)
            {
                Console.WriteLine("через" + i + "часа, столько Серёг" + sergei);
                sergei = sergei * 2;

            }

            Console.ReadKey();
        }
    }
}
