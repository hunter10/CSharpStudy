using System;

public class StackUsingArray
{
    private object[] a;
    private int top;

    public StackUsingArray(int capacity = 16)
    {
        a = new object[capacity];
        top = -1;
    }

    public void Push(object data)
    {
        if(top == a.Length -1)
        {
            ResizeStack();
        }

        a[++top] = data;
    }

    private void ResizeStack()
    {
        int capacity = 2 * a.Length;
        var tempArray = new object[capacity];
        Array.Copy(a, tempArray, a.Length);
        a = tempArray;
    }

    public object Pop()
    {
        if(this.IsEmpty)
        {
            throw new ApplicationException("Empty");
        }

        return a[top--];
    }

    public object Peek()
    {
        if(this.IsEmpty)
        {
            throw new ApplicationException("Empty");
        }

        return a[top];
    }

    public bool IsEmpty
    {
        get { return top == -1; }
    }

    public int capacity
    {
        get { return a.Length; }
    }
}