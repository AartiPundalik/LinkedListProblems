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
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        break;
                    case 2:
                        linkedlist.Display();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                    case 3:
                        flag = false;
                        break;
                        Console.ReadLine();
                }
            }
        }
    }
}
        
    

