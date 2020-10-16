using System;
using System.Diagnostics;
using System.Text;

namespace exam6_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            st.Start();
            DoSomething();
            st.Stop();
            
            Console.WriteLine(st.ElapsedMilliseconds);
        }

        static void DoSomething()
        {
            string txt = "Hello World";
            for(int i=0;i<300000; i++)
            {
                txt = txt + "1";
            }
        }

        static void DoSomething1()
        {
            string txt = "Hello World";

            StringBuilder sb = new StringBuilder();
            sb.Append(txt);

            for(int i=0;i<300000; i++)
            {
                //txt = txt + "1";
                sb.Append("1");
            }

            string newText = sb.ToString();
            //Console.WriteLine(newText);
        }
    }
}
