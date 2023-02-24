using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedList
    { 
            public Node head;
            public void Add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = node;
                }
                Console.WriteLine("{0} inserted into linked list ", node.data);
            }
            public void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list is empty");
                }
                Console.WriteLine("Linked list is: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
                Console.ReadLine();
            }
        public void AddReverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                node.Next = temp;
                head = node;
            }
            Console.WriteLine($"{node.data} is now Head");
            Console.ReadLine();
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                Console.WriteLine($"{node.data} is added after {temp.data}");
            }
            else { head = node; }
            Console.ReadLine();
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            this.head = this.head.Next;
            Console.WriteLine("the first element is deleted");
            Console.ReadLine();
        }
    }
}
    
    
    

       
    


