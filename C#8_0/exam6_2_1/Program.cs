using System;

namespace exam6_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string txt = "Hello World";

            Console.Write(txt + " Split('o'): ");
            OutputArrayString(txt.Split('o'));
        }

        private static void OutputArrayString(string[] arr)
        {
            foreach(string txt in arr)
            {
                Console.Write(txt + ", ");
            }

            Console.WriteLine();
        }
    }
}
