﻿using System;
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
        public Stacks
            ()
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
        public void pust( int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void pop()
        {
            Console.WriteLine("\n The popped element is :" + top.info);
            top = top.next;//Make the point to the node in sequence
        }
        public void display()
        {
            Node tmp;
            if (empty()) //if stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[]args)
        {
           Stacks  AM = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stacks Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your Choice :");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "68" : sInput);
                switch (ch)
                {

                }
            }


        }
    }

    
}
   
    
