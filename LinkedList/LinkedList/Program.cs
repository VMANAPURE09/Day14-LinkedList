using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Linked list = new Linked();
            list.Add(56);
            list.Append(30);
            list.Append(70);

            Console.WriteLine("Final LinkedList sequence is- ");
            list.Display();
        }
    }
}
