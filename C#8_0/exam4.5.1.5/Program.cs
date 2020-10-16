using System;

namespace exam4._5._1._5
{
    struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public override string ToString()
        {
            return "X = " + X + ", Y = " + Y;
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X = " + X + ", Y = " + Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Vector v1 = new Vector();
            Vector v2;

            Vector v3 = new Vector(5, 10);
            Console.WriteLine(v3);
            */

            /*
            Vector v1;
            v1.X = 5;
            v1.Y = 10;

            Change(ref v1);
            Console.WriteLine(v1);
            */

            // Point pt1 = new Point();
            // pt1.X = 5;
            // pt1.Y = 10;

            // Change(pt1);
            // Console.WriteLine(pt1);

            Point pt1 = null;
            Change1(pt1);
            Console.WriteLine("pt1:" + pt1);
            //Console.WriteLine("pt1: X=" + pt1.X + ", Y=" + pt1.Y);

            Change2(ref pt1);
            Console.WriteLine("pt1: X=" + pt1.X + ", Y=" + pt1.Y);
        }

        static void Change(ref Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }

        static void Change(Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }

        private static void Change1(Point pt) // 얕은 복사
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }

        private static void Change2(ref Point pt)
        {
            pt = new Point();
            pt.X = 7;
            pt.Y = 14;
        }
    }

    
}
