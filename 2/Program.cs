using System;

namespace _2
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
                int a = int.Parse(Console.ReadLine()); // считываем значение с консоли, int 
                int r = 0; // начальное значение перевернутого числа
                int x = a; // сохраняем введеное чсисло в другой переменной, чтобы потом его вывести в консоль

                while (a != 0) // пока а не равно 0
                {
                    r = r * 10 + a % 10;
                    a /= 10; // делим число а на 10
                }

                Console.WriteLine($"Число \"{x}\" в обратном порядке = \"{r}\"");
                Console.WriteLine("Если хочешь продолжить введи - true, если нет - false");
                // часть кода для повтора преобразования
                test = Console.ReadLine(); // считываем текст
                otvet = (test == "true" ? true : false); // сравниваем ответ с true, если совпадает не изменяем и повторяем действие с преобразованием, если нет, то заканчиваем
            }
        }
    }
}
