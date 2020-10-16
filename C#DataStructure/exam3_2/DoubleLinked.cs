using System;

namespace exam3_2
{
    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T data) : this(data, null, null)
        {
            this.Data = data;
            this.Prev = null;
            this.Next = null;
        }

        public DoublyLinkedListNode(T data, DoublyLinkedListNode<T> prev, DoublyLinkedListNode<T> next)
        {
            this.Data = data;
            this.Prev = prev;
            this.Next = next;
        }
    }

    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;

        public void Add(DoublyLinkedListNode<T> newNode)
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
                newNode.Prev = current;
                newNode.Next = null;
            }
        }

        public void AddAfter(DoublyLinkedListNode<T> current, DoublyLinkedListNode<T> newNode)
        {
            if(head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next.Prev = newNode;
            newNode.Prev = current;
            current.Next = newNode;
        }

        public void Remove(DoublyLinkedListNode<T> removeNode)
        {
            if(head == null || removeNode == null)
            {
                return;
            }

            // 삭제할 노드가 첫 노드이면
            if(removeNode == head)
            {
                head = head.Next;
                if(head != null)
                {
                    head.Prev = null;
                }
            }
            else // 첫노드가 아니면 Prev, Next 노드를 연결
            {
                removeNode.Prev.Next = removeNode.Next;
                if(removeNode.Next != null)
                {
                    removeNode.Next.Prev = removeNode.Prev;
                }
            }
            removeNode = null;
        }

        public DoublyLinkedListNode<T> GetNode(int index)
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