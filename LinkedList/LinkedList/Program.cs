using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            List list = new List();

            list.AddToEnd(56);
            list.AddToEnd(30);
            list.AddToEnd(70);
            list.Display();
        }
    }
}
