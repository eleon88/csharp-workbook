using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DoStuff dostuff = new DoStuff();

            Console.WriteLine("How old are you?");
            int Age = int.Parse(Console.ReadLine());

            string Greeting;
            if (Age > 75)
            {
                Greeting = "You're old! Hello, Eric! you are " + Age.ToString() + " years old";
            }
            else
            {
                Greeting = "Hello, Eric you are " + Age.ToString() + " years old";
            }

            Console.WriteLine(Greeting);

            Console.ReadLine();
        }
    }
}
