using System;

namespace zadanie_dop_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обрабатываем ошибки // но пока это не очень работает(
            {
                Console.Write("Введите число: ");
                int a = int.Parse(Console.ReadLine()); // считываем консоль и объявляем переменную
                int s = 0;

                Console.Write($"Сумма числел числа \"{a}\" = "); // первый вывод сообщения, чтобы не добавлять новую переменную
                while (a > 0) // пока a будет > 0, цикл будет работать
                {

                    s = s + a % 10; // раскладываем число на числа :)
                    a = a / 10; // сокращаем количество итераций цикла

                }
                Console.Write($"{s} "); // окончательный резульат

                // Console.WriteLine($"Сумма числел числа \"{a}\" = {s}"); // 
                Console.ReadKey();
            } catch (ExecutionEngineException ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
