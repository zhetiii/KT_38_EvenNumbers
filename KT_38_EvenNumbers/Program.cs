using System;
using System.Collections.Generic;
using System.Linq;

namespace KT_38_EvenNumbers
{
    internal class Program
    {
        public static IEnumerable<int> EvenNumbersUpTo(int max)
        {
            Console.WriteLine("[Трассировка метода] Старт работы EvenNumbersUpTo");
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"[Трассировка метода] Готовим значение: {i}");
                    yield return i;
                }
            }
            Console.WriteLine("[Трассировка метода] Конец работы EvenNumbersUpTo");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ ИТЕРАТОРОВ (YIELD RETURN) ===\n");

            var evenNumbersSequence = EvenNumbersUpTo(6);

            Console.WriteLine("Переменная создана, но цикл foreach еще не запущен.");
            Console.WriteLine("Обратите внимание: трассировки метода выше нет!\n");

            Console.WriteLine("--- Шаг 1: Полный перебор через foreach ---");
            foreach (var number in evenNumbersSequence)
            {
                Console.WriteLine($"[Main] Получено значение из итератора: {number}\n");
            }

            Console.WriteLine("--- Шаг 2: Демонстрация Take(2) ---");
            var limitedSequence = EvenNumbersUpTo(10).Take(2);

            foreach (var number in limitedSequence)
            {
                Console.WriteLine($"[Main] Получено по Take(2): {number}\n");
            }

            Console.WriteLine("Работа программы успешно завершена.");
        }
    }
}