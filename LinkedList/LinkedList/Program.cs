using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            List list = new List();

            list.AddToBeginning(56);
            list.AddToBeginning(30);
            list.AddToBeginning(70);
            list.Display();
        }
    }
}
