using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new OperationProcessor();
            processor.Run();
        }
    }
}
