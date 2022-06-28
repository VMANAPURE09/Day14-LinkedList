using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    internal class Class1
    {
        private Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} inserted into Linked list", node.data);
        }

        internal  void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = (Node)temp.next;
            }
        }

        
    }
}
