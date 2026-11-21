using System;
using System.Text;

namespace Lab1_Part2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть ціле невід'ємне число n (0..20): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Помилка: факторіал визначений лише для невід'ємних чисел.");
                return;
            }

            long factorial = 1;
            for (int i = 2; i <= n; i++) factorial *= i;

            Console.WriteLine($"Факторіал {n}! = {factorial}");
        }
    }
}
