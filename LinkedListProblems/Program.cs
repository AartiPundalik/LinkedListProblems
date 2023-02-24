using System;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1:");
                Console.WriteLine("2:");
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
                        linkedlist.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter Currect Option");
                        break;
                        
                }
            }
        }
    }
}
        
    

