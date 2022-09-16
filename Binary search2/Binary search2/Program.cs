using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search2
{
    internal class Program
    {
        // Binary Search 
        static void Main(string[] args)
        {
            int[] numberlist = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int low = 0;
            int high = numberlist.Length - 1;
            int findthis = 0;
            int guess = 0;

            while (findthis < 10 || findthis > 25)
            {
                try
                {
                    Console.WriteLine("Введите число от 10 до 25: ");
                    findthis = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
            }

            while (numberlist[guess] != findthis)
            {
                guess = (low + high) / 2;

                if(findthis < numberlist[guess])
                {
                    high = guess - 1;
                }
                else if (findthis > numberlist[guess])
                {
                    low = guess + 1;
                }
            }


            Console.WriteLine("Позиция числа " + findthis + " - " + guess);

        }
    }
}
