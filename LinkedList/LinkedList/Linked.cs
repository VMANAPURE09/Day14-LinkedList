﻿using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    internal class Linked
    {
        private Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }

        public bool Search(int input)
        {
            if (head == null)
            {
                throw new NullReferenceException("empty List");
            }

            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(input))
                    return true;
                t = t.next;
            }
            return false;

        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
