using System;

namespace exam3_2
{
    public class SinglyLinkedListNode<T>
    {
        public T Data { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T> head;

        public void Add(SinglyLinkedListNode<T> newNode)
        {
            if(head == null)        
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while(current != null && current.Next != null)    
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void AddAfter(SinglyLinkedListNode<T> current, SinglyLinkedListNode<T> newNode)
        {
            if(head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Remove(SinglyLinkedListNode<T> removeNode)
        {
            if(head == null || removeNode == null)
            {
                return;
            }

            // 삭제할 노드가 첫 노드이면
            if(removeNode == head)
            {
                head = head.Next;
                removeNode = null;
            }
            else
            {
                var current = head;
                while(current != null && current.Next != removeNode)
                {
                    current = current.Next;
                }

                if(current != null)
                {
                    current.Next = removeNode.Next;
                    removeNode = null;
                }
            }
        }

        public SinglyLinkedListNode<T> GetNode(int index)
        {
            var currnet = head;
            for(int i=0; i<index && currnet != null; i++)
            {
                currnet = currnet.Next;
            }
            return currnet;
        }

        public int Count()
        {
            int cnt = 0;

            var current = head;
            while(current != null)
            {
                cnt++;
                current = current.Next;
            }

            return cnt;
        }
    }
}