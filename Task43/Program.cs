// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System;
namespace Seminar6
{
    class task43
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите значения коэффициентов:");
            Console.ResetColor();
            Console.WriteLine("Введите коэффициенты для первой прямой:");
            Console.Write("k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты для второй прямой:");
            Console.Write("k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            if (k1==k2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Прямые не пересекаются, они параллельны");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                double x = (b2-b1)/(k1-k2);
                double y = k1*x+b1;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"({x}, {y})");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
