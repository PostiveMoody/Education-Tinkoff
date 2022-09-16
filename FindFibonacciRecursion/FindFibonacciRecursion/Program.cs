using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите элемент последовательности Фибоначчи который хотите получить: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(num - 1)); 
            


        }

        public static int Fibonacci(int num)
        {
             
            if (num < 2)
            {
                return num;
            }
            

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
