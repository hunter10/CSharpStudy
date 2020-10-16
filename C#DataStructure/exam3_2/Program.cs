using System;

namespace exam3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedList<int>();

            for(int i=0; i<5; i++)
            {
                list.Add(new SinglyLinkedListNode<int>(i));
            }

            var node = list.GetNode(2);
            list.Remove(node);

            node = list.GetNode(1);
            list.AddAfter(node, new SinglyLinkedListNode<int>(50));

            int count = list.Count();

            for(int i=0; i<count; i++)
            {
                var n = list.GetNode(i);
                Console.WriteLine(n.Data);
            }

            Console.WriteLine("======");

            var list1 = new DoublyLinkedList<int>();

            for(int i=0; i<5; i++)
            {
                list1.Add(new DoublyLinkedListNode<int>(i));
            }

            var node1 = list1.GetNode(2);
            list1.Remove(node1);

            node1 = list1.GetNode(1);
            list1.AddAfter(node1, new DoublyLinkedListNode<int>(50));

            int count1 = list.Count();

            for(int i=0; i<count1; i++)
            {
                var n = list1.GetNode(i);
                Console.WriteLine(n.Data);
            }
        }
    }
}
