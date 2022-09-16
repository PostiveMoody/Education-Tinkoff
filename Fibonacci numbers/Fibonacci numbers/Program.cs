using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> FibonacciList = new List<int>() { 0, 1};
            int fnumbers = 0;
            int N = 0;


            Console.WriteLine("Введите какой элемент из числа Фибоначчи вы хотите получить: ");
            N = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i < N; i++)
            {
                fnumbers = FibonacciList[i - 2] + FibonacciList[i - 1];
                FibonacciList.Add(fnumbers);
            }


            Console.WriteLine(FibonacciList[N-1]);
        }
    }
}
