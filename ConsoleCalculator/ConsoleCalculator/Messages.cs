using System;

namespace ConsoleCalculator
{
    internal static class Messages
    {
        public const string INTRO_TEXT = "Консольный калькулятор\n" +
            "Доступные операции для калькулятора: sum, sub, mult, div. Доступные переменные: int, double\n" +
            "Пример команды: sum 3 2.54 18\n" +
            "Пример команды: sub 3 2.6\n" +
            "Пример команды: mult 2 2.5 10\n" +
            "Пример команды: div 10 5 2\n";
        public const string ERROR_EMPTY_COMMAND = "Пустая команда. Введите команду и повторите попытку\n";
        public const string ERROR_CALC_INVALID = "Неверная команда. Доступные операции: sum, sub, mult, div.\nДоступные переменные: int, double\n";
        public const string ERROR_INVALID_COMMAND = "Недопустимая команда. Проверьте входные данные и повторите попытку\n";
    }
}
