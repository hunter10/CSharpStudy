using System;

namespace exam4._5._1._4
{
    class Computer
    {

    }

    interface IMonitor
    {
        void TurnOn();
        int Inch {get;set;}
        int Width{get;}
    }

    interface IKeyboard
    {

    }

    class Notebook : Computer, IMonitor, IKeyboard
    {
        public void TurnOn() {}

        int inch;
        public int Inch
        {
            get{return inch;}
            set{inch = value;}
        }

        int width;
        public int Width{get {return width;}}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Notebook notebook = new Notebook();
            notebook.TurnOn();

            //IMonitor mon = notebook as IMonitor;
            //mon.TurnOn();
        }
    }
}
