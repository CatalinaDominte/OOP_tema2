using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        privat string X { get; set; }
        privat Node NextNode { get; set; }


        public Node (string x)
        {
            X = x;
            NextNode = null;
            
        }
    }
}
