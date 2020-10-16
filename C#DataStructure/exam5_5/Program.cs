using System;

namespace exam5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = "2 * 3.4 + ( 15 - 2 ) / 2".Split(' ');

            var result = Calculator.Evalute(tokens);
            Console.Write(result);
        }
    }
}
