using System;

namespace exam7_3
{
    public class BinaryTreeUsingArray
    {
        private object[] arr;

        public BinaryTreeUsingArray(int capacity = 15)
        {
            arr = new object[capacity];
        }

        public object Root
        {
            get { return arr[0]; }
            set {arr[0] = value; }
        }

        public void SetLeft(int parentIndex, object data)
        {
            int leftIndex = parentIndex * 2 + 1;

            // 부모노드가 없거나 배열이 Null인 경우
            if(arr[parentIndex] == null || leftIndex >= arr.Length)
            {
                throw new ApplicationException("Error");
            }

            arr[leftIndex] = data;
        }

        public void SetRight(int parentIndex, object data)
        {
            int rightIndex = parentIndex * 2 + 2;

            if(arr[parentIndex] == null || rightIndex >= arr.Length)
            {
                throw new ApplicationException("Error");
            }

            arr[rightIndex] = data;
        }

        public object GetParent(int childIndex)
        {
            if(childIndex == 0) return null;

            int parentIndex = (childIndex - 1) / 2;
            return arr[parentIndex];
        }

        public object GetLeft(int parentIndex)
        {
            int leftIndex = parentIndex * 2 + 1;
            return arr[leftIndex];
        }

        public object GetRight(int parentIndex)
        {
            int rightIndex = parentIndex * 2 + 2;
            return arr[rightIndex];
        }

        public void PrintTree()
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("{0}({1}) ", arr[i] ?? "-", i);
            }

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // 샘플 이진 트리 구성
            //              A(0)
            //       B(1)           C(2)
            //   D(3)   -(4)    F(5)    -(6)  
            // 

            var bt = new BinaryTreeUsingArray(7);
            bt.Root = "A";
            bt.SetLeft(0, "B");
            bt.SetRight(0, "C");
            bt.SetLeft(1, "D");
            bt.SetLeft(2, "F");

            bt.PrintTree();

            var data = bt.GetParent(5);
            Console.WriteLine(data);

            data = bt.GetLeft(2);
            Console.WriteLine(data);
        }
    }
}
