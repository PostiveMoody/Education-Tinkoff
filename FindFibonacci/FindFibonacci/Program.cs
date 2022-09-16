using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int previous = 1;
            int preExisting = 1;
            int current = 0;
            int num = -1;

            
            while (num < 0)
            {
                try
                {
                    Console.WriteLine("Введите элемент из чисел Фибоначчи вы хотите получить: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Вы ввели в консоль не число, возьмите себя в руки\n" + ex);
                    continue;
                }
                
            }
            

            for (int i = 3; i < num; i++)
            {
                current = previous + preExisting;
                preExisting = previous;
                previous = current; 
            }

            Console.WriteLine(previous);

            Console.ReadLine();
        }
    }
}
