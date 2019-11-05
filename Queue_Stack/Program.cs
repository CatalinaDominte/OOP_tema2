using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack test = new MyStack();
            //test.Push("Ana");
            //test.Push("Maria");
            //test.Push("Ioan");
            //test.Push("Raluca");
            //test.Push("Alex");
            //test.Push("Cristina");
            //test.Pop();
            //test.PrintMyStack();
            

            MyQueue test1 = new MyQueue();
            test1.Enqueue("Ana");
            test1.Enqueue("Maria");
            test1.Enqueue("Ioan");
            test1.Enqueue("Raluca");
            test1.Enqueue("Alex");
            test1.Enqueue("Cristina");
            test1.Dequeue();
            test1.PrintQueue();
            Console.ReadLine();
        }
    }
}
