using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Linked list = new Linked();
            list.Add(70);
            list.Add(30);

            list.Add(56);
            Console.WriteLine("Final LinkedList Sequence Is- ");
            list.Display();
            Console.WriteLine("-------------------------");
            bool flag = list.Search(30);
            Console.WriteLine(flag);


        }
    }
}
