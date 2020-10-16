using System;

namespace exam4_21_1
{
    interface ISource
    {
        int GetResult();
    }

    class Source : ISource
    {
        public int GetResult() { return 10;}

        public void Test()
        {
            Target target = new Target();
            target.Do(this);
        }
    }

    class Target
    {
        public void Do(ISource obj)
        {
            Console.Write(obj.GetResult());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            //target.Do(new Source());
            
            Source source = new Source();
            target.Do(source);

        }
    }
}
