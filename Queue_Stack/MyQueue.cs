using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyQueue
    {
       public Node Front { get; set; }
        public Node Back { get; set; }

        public MyQueue()
        {
            Front = null;
            Back = null;
        }
        public void Enqueue(string val)
        {
            Node newNode = new Node(val);

            if (Back == null)
            {
                Front = Back = newNode;
            }
            else
            {

                Back.NextNode = newNode;
                Back = newNode;
            }
            Console.WriteLine($"{val} a fost adaugat in lista");
        }

        public void Dequeue()
        {
            if (this.Front == null)
            {
                Console.WriteLine("Lista este goala,");
            }

            Node temp = Front;
            Front = Front.NextNode;

            if (Front == null)
            {
                Back = null;
            }
            Console.WriteLine($"{temp.X} a fost sters" );
        }
        public void PrintQueue()
        {
            Node temp = Front;

            while (temp != null)
            {
                Console.Write(temp.X + " ");
                temp = temp.NextNode;
            }
           
        }



    }
}
