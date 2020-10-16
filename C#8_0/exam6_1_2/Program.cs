using System;

namespace exam6_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime now = DateTime.Now;

            Console.WriteLine("오늘날짜 " + now);

            TimeSpan gap = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜 " + gap.TotalDays);
        }
    }
}
