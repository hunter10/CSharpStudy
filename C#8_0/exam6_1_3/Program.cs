using System;
using System.Diagnostics;

namespace exam6_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Stopwatch st = new Stopwatch();

            st.Start();
            Sum();
            st.Stop();

            Console.WriteLine("Total Tick: " + st.ElapsedTicks);
            Console.WriteLine("Millisecond: " + st.ElapsedMilliseconds);
            Console.WriteLine("Second: " + st.ElapsedMilliseconds / 1000);
            Console.WriteLine("Second: " + st.ElapsedTicks / Stopwatch.Frequency);
        }

        private static long Sum()
        {
            long result = 0;
            for(int i=0; i<1000000; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
