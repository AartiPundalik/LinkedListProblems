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

        }
    }


