using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор! (Введите 'exit' для выхода)");

            while (true)
            {
                // 1. Безопасный ввод первого числа
                double num1 = GetNumberFromUser("Введите число 1: ");
                if (double.IsNaN(num1)) break; // Выход, если пользователь ввел 'exit'

                // 2. Безопасный ввод второго числа
                double num2 = GetNumberFromUser("Введите число 2: ");
                if (double.IsNaN(num2)) break;

                // 3. Ввод знака
                Console.Write("Выберите действие (+, -, *, /): ");
                string sign = Console.ReadLine()?.Trim();

                if (sign == "exit") break;

                // 4. Современное switch-выражение с паттерн-матчингом
                string output = sign switch
                {
                    "+" => $"{num1} + {num2} = {num1 + num2}",
                    "-" => $"{num1} - {num2} = {num1 - num2}",
                    "*" => $"{num1} * {num2} = {num1 * num2}",
                    "/" when num2 != 0 => $"{num1} / {num2} = {num1 / num2}",
                    "/" => "Ошибка: деление на ноль!",
                    _ => "Ошибка: неверная операция!"
                };

                Console.WriteLine(output);
                Console.WriteLine(new string('-', 30));
            }
        }

        // Вспомогательный метод для безопасного ввода чисел
        static double GetNumberFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit") return double.NaN;

                if (double.TryParse(input, out double number))
                {
                    return number;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пожалуйста, введите корректное число или 'exit' для выхода.");
                Console.ResetColor();
            }
        }
    }
}