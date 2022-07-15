// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
namespace Seminar6
{
    class Program
    {
        public static int PositiveNumCount(string[] numbers)
        {
            int numCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int element = Convert.ToInt32(numbers[i]);
                if (element > 0)
                {
                    numCount++;
                }
            }
            return numCount;
        }
        public static string Ending(int value)
        {
            string end = string.Empty;
            if (value == 1)
            { end = "ло"; }
            else
            {
                if (value > 1 && value < 5)
                { end = "ла"; }
                else
                {
                    end = "ел";
                }
            }
            return end;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            string[] input = Console.ReadLine()!.Split(" ");
            int count = PositiveNumCount(input);
            Console.WriteLine($"В введенном массиве {count} чис{Ending(count)} больше нуля");
        }
    }
}