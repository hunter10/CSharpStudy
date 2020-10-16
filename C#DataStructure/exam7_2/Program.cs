using System;
using System.Collections.Generic;

namespace exam7_2
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root
        {
            get; private set;
        }

        public BinaryTree(T root)
        {
            Root = new BinaryTreeNode<T>(root);
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(Root);
        }

        // 전위 순회 - 재귀로 구현
        private void PreorderTraversal(BinaryTreeNode<T> node)
        {
            if(node == null) return;

            Console.Write("{0} ", node.Data);
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
        }

        // 전위 순회 - 반복방식으로 구현
        public void PreorderIterative()
        {
            if(Root == null) return;
            
            var stack = new Stack<BinaryTreeNode<T>>();
            
            // 루트를 스택에 저장
            stack.Push(Root);

            while(stack.Count > 0)
            {
                // 스택에서 노드 가져옴
                var node = stack.Pop();

                // 방문
                Console.Write("{0} ", node.Data);

                // 오른족 노드 스택에 저장
                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }

                // 왼쪽 노드 스택에 저장
                if(node.Left != null)
                {
                    stack.Push(node.Left);
                }

            }
        }

        public void InorderTraversal()
        {
            InorderTraversal(Root);
        }

        private void InorderTraversal(BinaryTreeNode<T> node)
        {
            if(node == null) return;

            InorderTraversal(node.Left);
            Console.Write("{0} ", node.Data);
            InorderTraversal(node.Right);
        }

        public void InorderIterative()
        {
            var stack = new Stack<BinaryTreeNode<T>>();
            var node = Root;

            /*
            // Leftmost 노드까지 스택에 저장
            while(node != null)
            {
                stack.Push(node);
                node = node.Left;
            }

            while(stack.Count > 0)
            {
                // 스택에서 노드 가져옴
                node = stack.Pop();

                // 방문
                Console.Write("{0} ", node.Data);

                // 오른쪽 노드 있으면 루프돌아서 
                // Leftmost 노드까지 스택에 저장
                if(node.Right != null)
                {
                    node = node.Right;

                    while(node != null)
                    {
                        stack.Push(node);
                        node = node.Left;
                    }
                }
            }
            */
            while(node != null || stack.Count > 0)
            {
                // Leftmost 노드까지 스택에 저장
                while(node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }

                // 스택에서 노드 가져옴
                node = stack.Pop();

                // 방문
                Console.Write("{0} ", node.Data);

                // 오른쪽 노드 있으면 루프 돌아서 
                // Leftmost 노드까지 스택에 저장
                node = node.Right;
            }
        }

        public void PostorderTraversal()
        {
            PostorderTraversal(Root);
        }

        private void PostorderTraversal(BinaryTreeNode<T> node)
        {
            if(node == null) return;

            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);
            Console.Write("{0} ", node.Data);
        }

        public void PostorderIterative()
        {
            var stack = new Stack<BinaryTreeNode<T>>();
            var node = Root;

            /*
            // Leftmost 노드까지 오른쪽 자식노드와
            // 루트를 스택에 저장
            while(node != null)
            {
                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }
                stack.Push(node);
                node = node.Left;
            }

            while(stack.Count > 0)
            {
                // 스택에서 노드 가져옴
                node = stack.Pop();

                // 스택 Top이 오른쪽 자식노드와 같으면
                if(node.Right != null && 
                   stack.Count > 0 &&
                   node.Right == stack.Peek())
                {
                   // 오른쪽 자식 노드를 Pop
                   var right = stack.Pop();
                   
                   // 루트 노드를 다시 Push     
                   stack.Push(node);
                   node = right;

                   // Leftmost 노드까지 오른쪽 자식노드와 
                   // 루트를 스택에 저장
                   while(node != null)
                   {
                       if(node.Right != null)
                       {
                           stack.Push(node.Right);
                       }
                       stack.Push(node);
                       node = node.Left;
                   }
                }
                else
                {
                    // 방문
                    Console.Write("{0} ", node.Data);
                }
            }
            */

            while(node != null || stack.Count > 0)
            {
                // Leftmost 노드까지 오른쪽 자식노드와
                // 루트를 스택에 저장
                while(node != null)
                {
                    if(node.Right != null)
                    {
                        stack.Push(node.Right);
                    }

                    stack.Push(node);
                    node = node.Left;
                }
                
                // 스택에서 노드 가져옴
                node = stack.Pop();

                // 스택 Top이 오른쪽 자식노드와 같으면
                if(node.Right != null && 
                   stack.Count > 0 &&
                   node.Right == stack.Peek())
                {
                    // 오른쪽 자식노드를 Pop
                    var right = stack.Pop();

                    // 루트 노드를 다시 Push
                    stack.Push(node);

                    // 오른쪽 서브트리 루트 설정
                    node = right;
                }
                else
                {
                    // 방문
                    Console.Write("{0} ", node.Data);

                    // Leftmost 노드까지 스택 저장을 
                    // 하지 않도록 null 로 설정
                    node = null;
                }
            }
        }

        public void LevelorderTraversal()
        {
            var q = new Queue<BinaryTreeNode<T>>();
            q.Enqueue(Root);
            q.Enqueue(null); // 레벨끝 마크 추가

            while(q.Count > 0)
            {
                var node = q.Dequeue();

                if(node == null)
                {
                    // 새 라인
                    Console.WriteLine();

                    // 레벨끝 마크 다시 추가
                    if(q.Count > 0) q.Enqueue(null);
                    continue;
                }

                Console.Write($"{node.Data} ");
                    
                if(node.Left != null)
                {
                    q.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var bt = new BinaryTree<int>(1);

            var Two = new BinaryTreeNode<int>(2);
            var Three = new BinaryTreeNode<int>(3);
            var Four = new BinaryTreeNode<int>(4);
            var Five = new BinaryTreeNode<int>(5);
            var Six = new BinaryTreeNode<int>(6);
            var Seven = new BinaryTreeNode<int>(7);
            var Eight = new BinaryTreeNode<int>(8);
            var Nine = new BinaryTreeNode<int>(9);

            bt.Root.Left = Two;
            bt.Root.Right = Three;

            Two.Left = Four;
            Two.Right = Five;

            Three.Left = Six;
            Three.Right = Seven;

            Four.Left = Eight;
            Four.Right = Nine;

            //Console.WriteLine("PreorderTraversal");
            //bt.PreorderTraversal();

            //Console.WriteLine("InorderTraversal");
            //bt.InorderTraversal();

            //Console.WriteLine("PostorderTraversal");
            //bt.PostorderTraversal();

            Console.WriteLine("LevelorderTraversal");
            bt.LevelorderTraversal();

            Console.WriteLine();

            //Console.WriteLine("PreorderIterative");
            //bt.PreorderIterative();

            //Console.WriteLine("InorderIterative");
            //bt.InorderIterative();

            Console.WriteLine("PostorderIterative");
            bt.PostorderIterative();
        }
    }
}
