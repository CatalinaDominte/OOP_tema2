using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack
    {
         Node Top { get; set; }

        public MyStack()
        {
           
            Top = null;
        }
        public void Push(string no)
        {
            Node newNode = new Node(no);
            if (Top == null)
            {
                newNode.NextNode = null;
            }
            else
            {
                newNode.NextNode = Top;

            }
            Top = newNode;
            Console.WriteLine($"{no} a fost  adaugat listei");
        }
        public void Pop()

        {
            Node top = Top;
            if (Top == null)
            {
                Console.WriteLine("Stergerea nu poate fi finalizata");

            }
            Console.WriteLine($" {top.X} a fost sters");
            Top = Top.NextNode;
        }
        public void PrintMyStack()
        {
            Node temp = Top;

            while (temp != null)
            {
                Console.WriteLine(temp.X);
                temp = temp.NextNode;
            }
            
        }

    }
   
}
