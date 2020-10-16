using System;
using System.Collections;

namespace exam6_4_1
{
    public class Person : IComparable
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int CompareTo(object obj)
        {
            Person target = (Person)obj;

            if(this.Age > target.Age) return 1;
            else if(this.Age == target.Age) return 0;

            return -1;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList ar = new ArrayList();

            ar.Add(new Person(17, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27, "Paul"));

            ar.Sort();

            foreach(Person person in ar)
            {
                Console.WriteLine(person);
            }
            */

            SortedList sl = new SortedList();

            sl.Add(32, "Cooper");
            sl.Add(56, "Anderson");
            sl.Add(17, "Sammy");
            sl.Add(27, "Paul");

            foreach(int key in sl.GetKeyList())
            {
                Console.WriteLine(string.Format("{0} {1}", key, sl[key]));
            }

            sl.Add(27, "JIS");
        }
    }
}
