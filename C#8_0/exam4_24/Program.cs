using System;
using System.Collections;

namespace exam4_24
{
    class IntegerComapre : IComparer
    {
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if(xValue < yValue) return -1;
            else if(xValue == yValue) return 0;

            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {1,2,3,4,5};

            Array.Sort(intArray, new IntegerComapre());
            foreach(int item in intArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
