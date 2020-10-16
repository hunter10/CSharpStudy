using System;

namespace exam6_2
{
    class TreeNode
    {
        public object Data { get; set; }
        public TreeNode[] Links { get; private set; }

        public TreeNode(object data, int maxDegree = 3)
        {
            Data = data;
            Links = new TreeNode[maxDegree];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var A = new TreeNode("A");
            var B = new TreeNode("B");
            var C = new TreeNode("C");
            var D = new TreeNode("D");

            A.Links[0] = B;
            A.Links[1] = C;
            A.Links[2] = D;

            B.Links[0] = new TreeNode("E");
            B.Links[1] = new TreeNode("F");

            D.Links[0] = new TreeNode("G");

            foreach(var node in A.Links)
            {
                Console.WriteLine(node.Data);
            }
        }
    }
}
