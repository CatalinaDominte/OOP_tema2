using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack Test1 = new MyStack();

            Test1.Push("Ana");
            Test1.Push("Maria");
            Test1.Push("Sara");
            Test1.Push("Gabi");
            Test1.Push("Alina");
            Test1.Pop();
            Test1.Print();

            MyQueue Test2 = new MyQueue();
            Test2.Enqueue("f");
            Test2.Enqueue("v");
            Test2.Enqueue("k");
            Test2.Enqueue("i");
            Test2.Enqueue("e");
            Test2.Dequeue();
            Test2.Print();

            Console.Read();
        }
    }
}
