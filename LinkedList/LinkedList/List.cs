using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class List
    {
        public Node head;

        public void AddToEnd(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}