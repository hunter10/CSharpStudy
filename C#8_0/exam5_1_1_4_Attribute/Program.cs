using System;

namespace exam5_1_1_4_Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class AuthorAttribute : System.Attribute
    {
        int _version;
        public int Version
        {
            get{return _version;}
            set{_version = value;}
        }

        string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }
    }

    /*
    [AuthorAttribute]
    class Dummy1
    {
    }

    [Author]
    class Dummy2
    {
    }

    [Author()]
    class Dummy3
    {
    }
    */

    [type: Author("Tester")]
    
    class Program
    {
        [method: Author("Tester")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
