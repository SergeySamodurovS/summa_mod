using System;
using static System.Console;

namespace sum_mod
{
    class Program
    {
        static int Main(string[] args)
        {
            const int SIZE = 100;
            int[] array = new int[SIZE];
            Random random = new Random();
            int modul = 4;
            int counter = 0;
            int summa = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
            }

            foreach (var item in array)
            {
                if(item%2 == 1)
                {
                    counter++;
                    if (counter%2 == 0)
                    {
                        summa = (summa + item) % modul;
                    }
                }
            }

            return summa;
        }
    }
}
