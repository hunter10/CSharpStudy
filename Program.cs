using System;

class Person
{
    public string _name;

    public Person(string name)
    {
        _name = name;
        Console.WriteLine("ctor 실행");
    }

    static Person()
    {
        Console.WriteLine("cctor 실행");
    }
}

namespace CSharp_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("");
            Console.WriteLine("Hello World!");
            Person person2 = new Person("");
        }
    }
}
