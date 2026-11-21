using System;
using System.Text;

namespace Lab1_Part1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Введіть кількість рядків у масиві: ");
            int n = int.Parse(Console.ReadLine());

            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Рядок [{i}]: ");
                lines[i] = Console.ReadLine();
            }

            Console.Write("\nВведіть фрагмент для пошуку: ");
            string findThisString = Console.ReadLine();

            Console.WriteLine("\nРезультати пошуку:");
            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                int pos = lines[i].IndexOf(findThisString);
                if (pos != -1)
                {
                    Console.WriteLine($"Рядок [{i}]: \"{lines[i]}\" -> позиція входження: {pos}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Збігів не знайдено (IndexOf повернув -1).");
        }
    }
}
