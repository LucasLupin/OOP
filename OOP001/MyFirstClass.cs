using System;
namespace OOP001
{
    internal class MyFirstClass
    {
        private string str;

        public int Age { get; set; }

        public MyFirstClass()
        {
            Console.WriteLine("Hello World");
        }
        public void Mymethod()
        {
            Console.WriteLine("Welcome to my method." + str);
        }

    }
}

