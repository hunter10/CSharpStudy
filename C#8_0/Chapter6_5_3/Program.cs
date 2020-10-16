using System;
using System.IO;
using System.Threading;

namespace Chapter6_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            foreach(string txt in Directory.GetLogicalDrives())
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine();

            string targetPath = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetFiles(targetPath))
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine();

            foreach(string txt in Directory.GetDirectories(targetPath))
            {
                Console.WriteLine(txt);
            }
            */

            //string filePath = Path.Combine(@"C:\temp\", "test", "myfile.dat");
            //Console.WriteLine(filePath);

            // string createTempFilePath = Path.GetTempFileName();
            // Console.WriteLine(createTempFilePath);

            // string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            // Console.WriteLine(tempFilePath);

            //Thread thread = Thread.CurrentThread;
            //Console.WriteLine(thread.ThreadState);

            // Console.WriteLine(DateTime.Now);
            // Thread.Sleep(1000);
            // Console.WriteLine(DateTime.Now);

            Thread t = new Thread(threadFunc);
            // t.IsBackground = true;
            // t.Start();
            // t.Join();
            // Console.WriteLine("주 스레드 종료");
            
             t.Start(11);
        }

        static void threadFunc(object initialValue)
        {
            // Console.WriteLine("10초 후에 프로그램 종료");
            // Thread.Sleep(1000*10);
            // Console.WriteLine("스레드 종료!");

            int intValue = (int)initialValue;
            Console.WriteLine(intValue);
        }
    }
}
