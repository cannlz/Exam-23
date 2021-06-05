using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StockClass
    {
        public int razm;
        public int count;

        public void Schet()
        {
            Console.Write("Введите размерность массива: ");
            razm = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[razm];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10,10);
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0 )
                {
                    count++;
                }
            }
            Console.WriteLine("Кол-во положителдьных чисел: " + count);
            Console.ReadKey();
        }
    }
}
