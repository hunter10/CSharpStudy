using System;

namespace exam4_22
{
    class SortObject
    {
        public delegate bool AAADelegate(int arg1, int arg2);

        int[] numbers;
        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void Sort(AAADelegate compareMethod)
        {
            int temp;
            for(int i=0; i<numbers.Length; i++)
            {
                int lowPos = i;
                for(int j=i+1; j<numbers.Length; j++)
                {
                    if(compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[]{5,2,3,1,0,4};

            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare);
            so.Display();

            Console.WriteLine();

            so.Sort(DescendingCompare);
            so.Display();
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }

        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
}
