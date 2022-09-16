using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asimptotics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int low = 0;
            int high = numbers.Length - 1;
            int guess = 0;
            int midpoint = 0;

            while (guess < 10 || guess > 25)
            {
                try
                {
                    Console.WriteLine("Введите число от 10 до 25 : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
                
            }

            while (numbers[midpoint] != guess)
            {
                midpoint = (low + high) / 2;

                if(numbers[midpoint] < guess)
                {
                    low = midpoint + 1;
                }
                else if (numbers[midpoint] > guess)
                {
                    high = midpoint - 1;
                }
            }

            Console.WriteLine("Позиция числа " + midpoint + " - " + numbers[guess]);
        }
    }
}
