using System;
public class QueueUsingCircularArray
{
    // 단순화를 위해 object 데이타 타입 사용
    private object[] a;
    private int front;
    private int rear;

    // 디폴트 큐 크기는 16 이지만 지정가능
    public QueueUsingCircularArray(int queueSize = 16)
    {
        a = new object[queueSize];
        front = -1;
        rear = -1;
    }

    public void Enqueue(object data)
    {
        // 큐가 가득차 있는지 체크
        if((rear + 1) % a.Length == front)
        {
            throw new ApplicationException("Full");
        }
        else
        {
            // 비어있는 경우
            if(front == -1)
            {
                front++;
            }

            // 데이터 추가
            rear = (rear + 1) % a.Length;
            a[rear] = data;
        }
    }

    public object Dequeue()
    {
        // 큐가 비어 있는지 체크
        if(front == -1 && rear == -1)
        {
            throw new ApplicationException("Empty");
        }
        else
        {
            // 데이터 읽기 
            object data = a[front];

            // 마지막 요소를 읽은 경우
            if(front == rear)
            {
                front = -1;
                rear = -1;
 
            }
            else
            {
                // front 이동
                front = (front + 1) % a.Length;
            }

            return data;
        }
    }
}