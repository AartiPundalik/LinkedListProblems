using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            LinkedListStack Stack = new LinkedListStack();
            Queue queue = new Queue();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an number");
              
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        break;
                    case 2:
                        linkedlist.AddReverse(56);
                        linkedlist.AddReverse(30);
                        linkedlist.AddReverse(70);
                        break;
                    case 3:
                        linkedlist.Append(56);
                        linkedlist.Append(30);
                        linkedlist.Append(70);
                        break;
                    case 4:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveFirstNode();
                        break;
                    case 5:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveLastNode();
                        break;
                    case 6:
                        linkedlist.Add(56);
                        linkedlist.Add(56);
                        linkedlist.Add(56);
                        linkedlist.Search(56);
                        linkedlist.Search(30);
                        break;
                    case 7:
                        linkedlist.Add(56);
                        linkedlist.Add(56);
                        linkedlist.Add(56);
                        linkedlist.Size();
                        break;
                    case 8:
                        Stack.Push(10);
                        Stack.Push(20);
                        Stack.Push(30);
                        Stack.Display();
                        break;
                    case 9:
                        Stack.Push(10);
                        Stack.Push(20);
                        Stack.Push(30);
                        Stack.Pop();
                        Stack.Display();
                        break;
                    case 10:
                        linkedlist.Display();
                        break;
                    case 11:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        break;
                    case 12:
                        queue.Dequeue();
                        break;
                        case 13:
                        queue.Display();
                        break;
                    default:Console.WriteLine("Enter current option");
                        break;
                    
                }
            }
        }
    }
}
        
    

