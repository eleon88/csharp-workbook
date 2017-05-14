using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    public class Person
    {
        public string name;
        public int age;
        public void speaks(string name, int age)
        {

            Console.WriteLine("Hello {0}, your age is {1}", name, age);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your name?");
            // string name = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            // int age = Convert.ToInt32(Console.ReadLine());


            Person eric = new Person()
            {
                name = "Eric",
                age = 29
            };

            Person john = new Person()
            {
                name = "john",
                age = 35
            };


            // eric.speaks(name, age);
            //  john.speaks(john.name, john.age);

            List<Person> c = new List<Person>(2);
            c.Add(eric);
            c.Add(john);
            c.Insert(0, john);

            foreach (Person i in c)
            {
                i.speaks(i.name, i.age);
            }

            // for (int i = 0; i < c.Count; i++)
            // {
            //   Person x = c[i];
            // x.speaks(x.name, x.age);
            //}

        }
    }

}