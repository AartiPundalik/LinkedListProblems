using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedListStack
    {
        public Node top;


        public LinkedListStack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.Next = null;
            else
                node.Next = this.top;
            this.top = node;
            Console.WriteLine(value);

        }


        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("stack is ");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine("");
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("value poped is " + this.top.Data);
            this.top = this.top.Next;

        }
    }
}

    

