using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class OperationFabric
    {
        public OperationBase SelectOperation(string operation)
        {
            OperationBase choosenOperation = null;

            switch (operation)
            {
                case "sum":
                    choosenOperation = new SumOperation();
                    break;
                case "sub":
                    choosenOperation = new SubOperation();
                    break;
                case "mult":
                    choosenOperation = new MultOperation();
                    break;
                case "div":
                    choosenOperation = new DivOperation();
                    break;
                default:
                    Console.WriteLine(Messages.ERROR_INVALID_COMMAND);
                    break;
            }
            return choosenOperation;
        }
    }
}
