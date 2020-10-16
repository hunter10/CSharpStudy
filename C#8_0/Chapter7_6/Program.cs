using System;
using System.Threading;

namespace Chapter7_6
{
    class Program
    {
        bool? _getMarried;
        bool? GetMarried
        {
            get { return _getMarried; }
            set { _getMarried = value; }
        }

        static void Main(string[] args)
        {
            // Program pg = new Program();
            // pg.GetMarried = true;
            // Console.WriteLine(pg.GetMarried.HasValue);
            // Console.WriteLine(pg.GetMarried.HasValue ? "not null" : "null");

            Thread thread = new Thread(
                //ThreadFunc
                delegate (object obj){
                    Console.WriteLine("ThreadFunc in anoymous method called!");
                });
            thread.Start();
            thread.Join();
        }

        static void ThreadFunc(object obj)
        {
            Console.WriteLine("Thread called!");
        }
        
    }

}
