using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            name = "Khathutshelo";
            age = 23;

            Console.WriteLine("Hi " + name);
            Console.WriteLine("You are " + age);

            name = "John";
            age = 25;

            Console.WriteLine("He never liked his name , at age " + age + " He changed to " + name);

            Console.ReadLine();
        }
    }
}
