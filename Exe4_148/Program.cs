using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_148
{
    class Node
    {
        public int info;
        public Node next;
        public Node (int AM, Node n)
        {
            info = AM;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return(true);
            else
                return(false);

        }


    }
}
   
    
