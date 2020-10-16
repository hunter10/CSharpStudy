using System;

namespace exam2_4
{
    class Program
    {
        // 시작 인덱스부터 시작해서 모든 배열값을 출력하라
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            char[] A = "abcdefgh".ToCharArray();
            int startIndex = 2;

            for(int i=0 ; i<A.Length; i++)
            {
                int index = (startIndex + i) % A.Length;
                Console.Write(A[index]);
            }
        }
    }
}
