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
            list.Add(56);
            Console.WriteLine("Final LinkedList Sequence before using Pop Method Is- ");
            list.Display();
            list.Pop(0);
            Console.WriteLine("Final LinkedList Sequence after applied Pop Method Is- ");
            list.Display();

        }
    }
}
