using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool otvet = true;
            string test; // переменная для сравнения ответа
            while (otvet) // работает пока переменная равна true 
            {
                int perv, posl, a, b, c, d; // переменные
                Console.Write("Введите число: ");
                int n = int.Parse(Console.ReadLine());

                posl = n % 10; // полседняя цифра
                d = n;
                c = n;
                b = n;
                a = 1;
                perv = 0;

                if (b < 0) // условие
                {
                    Console.WriteLine("Число не может быть меньше 0!");
                    return;
                }

                while ( b > 0) // пока b > 0, выполняем
                {
                    perv = b % 10;
                    a = a * 10;
                    b /= 10;
                }
                b = c - perv * (a / 10) + posl * (a / 10) - posl + perv;
                Console.WriteLine($"Изменил последнюю и первую цифру числа \"{d}\" = \"{b}\"");
                Console.WriteLine("Если хочешь продолжить введи - true (t), если нет - false (f)");
                // часть кода для повтора кода
                test = Console.ReadLine(); // считываем текст
                otvet = ((test == "true" || test == "t") ? true : false); // сравниваем ответ с true, если совпадает не изменяем и повторяем действие с преобразованием, если нет, то заканчиваем
            }
        }
    }
}
