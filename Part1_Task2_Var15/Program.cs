using System;
using System.Text;

namespace Lab1_Part1_Task2_Var15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int N = 180;
            const int K = 10;
            int[] arr = new int[N];
            Random rand = new Random();

            Console.WriteLine("Згенерований масив із 180 елементів (діапазон 0..100):");
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(0, 101);
                Console.Write($"{arr[i],4}");
                if ((i + 1) % 20 == 0) Console.WriteLine();
            }

            int currentSum = 0;
            for (int i = 0; i < K; i++) currentSum += arr[i];

            int maxSum = currentSum;
            int bestStartIndex = 0;

            for (int i = K; i < N; i++)
            {
                currentSum = currentSum - arr[i - K] + arr[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStartIndex = i - K + 1;
                }
            }

            Console.WriteLine($"\nМаксимальна сума ділянки з {K} елементів: {maxSum}");
            Console.WriteLine($"Початковий індекс ділянки: {bestStartIndex} (індекси {bestStartIndex}..{bestStartIndex + K - 1})");
            Console.Write("Елементи знайденої ділянки: ");
            for (int i = bestStartIndex; i < bestStartIndex + K; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
