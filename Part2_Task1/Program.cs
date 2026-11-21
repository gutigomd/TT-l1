using System;
using System.Text;

namespace Lab1_Part2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Розв'язання квадратного рівняння ax^2 + bx + c = 0");
            Console.Write("Введіть коефіцієнт a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть коефіцієнт b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть коефіцієнт c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b != 0) Console.WriteLine($"Рівняння лінійне. Корінь: x = {-c / b:F4}");
                else Console.WriteLine(c == 0 ? "Безліч розв'язків." : "Розв'язків немає.");
                return;
            }

            double D = b * b - 4 * a * c;
            Console.WriteLine($"Дискримінант D = {D:F4}");

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Два дійсні корені: x1 = {x1:F4}, x2 = {x2:F4}");
            }
            else if (D == 0)
            {
                Console.WriteLine($"Один дійсний корінь: x = {-b / (2 * a):F4}");
            }
            else
            {
                Console.WriteLine("Дійсних коренів немає (D < 0).");
            }
        }
    }
}
