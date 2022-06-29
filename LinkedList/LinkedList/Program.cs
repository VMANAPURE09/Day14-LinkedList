using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Linked list = new Linked();
            list.Add(70);
            list.Add(56);
            list.Insert(1,30);

            Console.WriteLine("Final LinkedList sequence is- ");
            list.Display();
        }
    }
}
