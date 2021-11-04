using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool otvet = true;
            string test; // переменная для сравнения ответа
            while (otvet) // работает пока переменная равна true 
            {
                Console.Write("Введите число: ");
                int a = int.Parse(Console.ReadLine()); // считываем консоль и объявляем переменную
                int s = 0, max = 0, x = a; // число суммы, максимальное число из чисел, введеное число

                while (a > 0) // пока a будет > 0, цикл работает
                {
                    s = a % 10; // раскладываем число на числа :)
                    // Console.WriteLine(s);
                    max = (max < s) ? s : max; //проверяем максимальное число, max < s, изменяем, если нет, то не трогаем
                    a = a / 10; // сокращаем количество итераций цикла
                };

                Console.WriteLine($"Наибольшее число в числе \"{x}\" = {max}"); // окончательный резульат
                Console.WriteLine("Если хочешь продолжить введи - true (t), если нет - false (f)");
                // часть кода для повтора кода
                test = Console.ReadLine(); // считываем текст
               otvet = ((test == "true" || test == "t") ? true : false); // сравниваем ответ с true, если совпадает не изменяем и повторяем действие с преобразованием, если нет, то заканчиваем
            }
        }
    }
}
