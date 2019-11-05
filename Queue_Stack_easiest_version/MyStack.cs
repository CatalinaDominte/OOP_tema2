using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_stack
{
    class MyStack
    {
        LinkedList<String> my_list { get; set; } = new LinkedList<String>();

        public void Push(string value)
        {
            my_list.AddFirst(value);
            Console.WriteLine($"{value} a fost adaugat");
        }
        public void Pop()
        {
            my_list.RemoveFirst();

            Console.WriteLine($"Ultimul item adaugat a fost sters");
        }
        public void Print()
        {
            foreach (string item in my_list)
            {
                Console.Write(item);
            }
        }

       
}

}
