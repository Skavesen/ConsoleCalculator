using System;
using System.Globalization;

namespace ConsoleCalculator
{
    /// <summary>
    /// Базовый класс для всех операций
    /// </summary>
    internal abstract class OperationBase
    {
        /// <summary>
        /// Шаблон завершения операции
        /// </summary>
        /// <param name="splitedInput"></param>
        public void CompleteOperation(string[] splitedInput)
        {
            if(Validate(splitedInput))
                Execute(splitedInput);
        }

        //Проверка ввода
        protected abstract bool Validate(string[] splitedInput);

        //Выполнить операцию: переопределено для каждой операции
        protected abstract void Execute(string[] splitedInput);
    }
}
