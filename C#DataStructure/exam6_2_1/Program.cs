using System;

namespace exam6_2_1
{
    class LCRSNode
    {
        public object Data { set; get; }
        public LCRSNode LeftChild { get; set; }
        public LCRSNode RightSibling { get; set; }

        public LCRSNode(object data)
        {
            this.Data = data;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var A = new LCRSNode("A");
            var B = new LCRSNode("B");
            var C = new LCRSNode("C");
            var D = new LCRSNode("D");
            var E = new LCRSNode("E");
            var F = new LCRSNode("F");
            var G = new LCRSNode("G");

            A.LeftChild = B;
            B.RightSibling = C;
            C.RightSibling = D;
            B.LeftChild = E;
            E.RightSibling = F;
            D.LeftChild = G;

            if(A.LeftChild != null)
            {
                var tmp = A.LeftChild;
                Console.WriteLine(tmp.Data);

                while(tmp.RightSibling != null)
                {
                    tmp = tmp.RightSibling;
                    Console.WriteLine(tmp.Data);
                }
            }
        }
    }
}
