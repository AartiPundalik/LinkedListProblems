using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            Console.WriteLine("{0} inserted into linked list ", node.Data);
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
                Console.WriteLine(temp.Data + " ");
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
            Console.WriteLine($"{node.Data} is now Head");
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
                Console.WriteLine($"{node.Data} is added after {temp.Data}");
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
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("lined list is empty");
            }
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.Next.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = null;
                Console.WriteLine("the last element is deleted");
            }
        }
        public void Search(int Data)
        {
            int count = 0;
            Node tempNode = this.head;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.Data.Equals(Data))
                    {
                        count++;
                    }
                    tempNode = tempNode.Next;
                }
            }
            if (count > 0)
                Console.WriteLine(Data + " data found " + count + ": time ");
            else
                Console.WriteLine(" data not found\n");
        }

    }
}



    
    

       
    


