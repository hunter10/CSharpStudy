using System;
using System.Collections.Generic;

namespace exam6_2_2
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

    class LCRSTree
    {
        public LCRSNode Root { get; private set; }

        public LCRSTree(object rootData)
        {
            this.Root = new LCRSNode(rootData);
        }

        public LCRSNode AddChild(LCRSNode parent, object data)
        {
            if (parent == null) return null;

            LCRSNode child = new LCRSNode(data);

            if(parent.LeftChild == null)
            {
                parent.LeftChild = child;
            }
            else
            {
                var node = parent.LeftChild;
                while(node.RightSibling != null)
                {
                    node = node.RightSibling;
                }
                node.RightSibling = child;
            }

            return child;
        }

        public LCRSNode AddSibling(LCRSNode node, object data)
        {
            if (node == null) return null;

            while(node.RightSibling != null)
            {
                node = node.RightSibling;
            }

            var sibling = new LCRSNode(data);
            node.RightSibling = sibling;

            return sibling;
        }

        public void PrintLevelOrder()
        {
            var q = new Queue<LCRSNode>();
            q.Enqueue(this.Root);

            while(q.Count > 0)
            {
                var node = q.Dequeue();

                while(node != null)
                {
                    Console.Write($"{node.Data} ");
                    if(node.LeftChild != null)
                    {
                        q.Enqueue(node.LeftChild);
                    }
                    node = node.RightSibling;
                }
            }
        }

        public void PrintIndentTree()
        {
            PrintIndent(this.Root, 1);
        }

        private void PrintIndent(LCRSNode node, int indent)
        {
            if(node == null) return;

            // 현재노드 출력
            string pad = " ".PadLeft(indent);
            Console.WriteLine($"{pad}{node.Data}");

            // 왼쪽자식
            PrintIndent(node.LeftChild, indent + 1);

            // 오른쪽 형제
            PrintIndent(node.RightSibling, indent);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            LCRSTree tree = new LCRSTree("A");
            var A = tree.Root;
            var B = tree.AddChild(A, "B");
            tree.AddChild(A, "C");
            var D = tree.AddSibling(B, "D");
            tree.AddChild(B, "E");
            tree.AddChild(B, "F");
            tree.AddChild(D, "G");

            tree.PrintIndentTree();

            Console.WriteLine();
            tree.PrintLevelOrder();
        }
    }
}
