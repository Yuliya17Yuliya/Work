using System;

namespace LW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входные данные
            int A, B, C;
            
            // Выходные данные
            int k=0;

            // Запрос входных данных
            Console.Write("Введите значение A (целое число):");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B (целое число):");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C (целое число):");
            C = Convert.ToInt32(Console.ReadLine());

            // Вычесление результата
            if (A>0) k = k + 1;
            if (B>0) k = k + 1;
            if (C>0) k = k + 1;

            // Вывод результата
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Количество положительных чисел: {k}");
        }
    }
}
