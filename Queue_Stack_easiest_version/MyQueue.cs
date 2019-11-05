using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_stack
{
    class MyQueue
    {
        LinkedList<String> QueueList { get; set; } = new LinkedList<String>();

        public void Enqueue(string value)
        {
            QueueList.AddFirst(value);
            Console.WriteLine($"{value} a fost adaugat");
        }
        public void Dequeue()
        {
            QueueList.RemoveLast();

            Console.WriteLine($"Primul item adaugat in lista a fost sters");
        }
        public void Print()
        {
            foreach (string item in QueueList)
            {
                Console.Write(item);
            }
        }
    }
}
