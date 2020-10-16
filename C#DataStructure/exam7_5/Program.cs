using System;
using System.Linq;

namespace exam7_5
{
    public class ExpressionTree
    {
        public Node Root { get; set; }

        // 수식트리 구축
        // ex) tokens = " 10 4 / 3 5 * +".Split(' ');
        public void Build(string[] tokens)
        {
            int index = tokens.Length - 1;
            Root = Build(tokens, ref index);
        }

        private Node Build(string[] tokens, ref int index)
        {
            // 연산자 혹은 피연산자 노드 생성
            Node node = new Node(tokens[index]);

            // 연산자이면
            if(tokens[index] == "+" ||
               tokens[index] == "-" ||
               tokens[index] == "*" ||
               tokens[index] == "/" )
            {
                // 오른쪽 서브트리 Build
                --index;
                node.Right = Build(tokens, ref index);

                // 왼쪽 서브트리 Build
                --index;
                node.Left = Build(tokens, ref index);
            }

            // 연산자 혹은 피연산자 노드 리턴
            return node;
        }

        public decimal Evaluate(Node root)
        {
            if(root == null) return 0;

            // 왼쪽 서브트리 계산
            decimal left = Evaluate(root.Left);

            // 오른쪽 서브트리 계산
            decimal right = Evaluate(root.Right);

            // 연산자이면 계산
            if(root.Data == "+")
            {
                return left + right;
            }
            else if(root.Data == "-")
            {
                return left - right;
            }
            else if(root.Data == "*")
            {
                return left * right;
            }
            else if(root.Data == "/")
            {
                return left / right;
            }

            // 피연산자이면 값 리턴
            return decimal.Parse(root.Data);
        }

        // 중위순회 : Infix
        public void Inorder(Node node)
        {
            if(node == null) return;

            // 연산자이면 괄호열기
            if(IsOperator(node.Data))
            {
                Console.Write("(");
            }

            Inorder(node.Left);
            Console.Write($" {node.Data} ");
            Inorder(node.Right);

            // 연산자이면 괄호닫기
            if(IsOperator(node.Data))
            { 
                Console.Write(")");
            }
        }

        // 후위순회 : Postfix
        public void Postorder(Node node)
        {
            if(node == null) return;

            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write($" {node.Data} ");
        }
         
        private string[] op = {"+", "-", "*", "/"};
        private bool IsOperator(string token)
        {
            return op.Contains(token);
        }
    }

    public class Node
    {
        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(string data)
        {
            this.Data = data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var postfix = "10 4 / 3 5 * +".Split(' ');

            var et = new ExpressionTree();
            et.Build(postfix);

            Console.Write("Inorder: ");
            et.Inorder(et.Root);
            Console.WriteLine();

            Console.Write("Postorder: ");
            et.Postorder(et.Root);
            Console.WriteLine();

            var result = et.Evaluate(et.Root);
            Console.WriteLine($"Result: {result}");
        }
    }
}
