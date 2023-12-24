using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class LinkedList
    {
        private Node head;

        public LinkedList() 
        {
            head = null;
        } 

        private Node GetLastNode()
        {
            if (head == null)
            {
                throw new Exception("Linked List is empty");
            }
            Node x = head;
            while (x.link != null) 
            { 
                x = x.link;
            }
            return x;
        }

        public void AddNode(int value)
        {
            if(head is null)
            {
                head = new Node(value);
            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.link = new Node(value);
            }

        }

        public void PrintAllNodes()
        {
            void printall(Node i)
            {
                if (i is null)
                {
                    return;
                }
                Console.WriteLine(i.value);
                i = i.link;
                printall(i);
            }

            if (head is null)
            {
                throw new Exception("List is empty");
            }
            printall(head);

        }
    }
}
