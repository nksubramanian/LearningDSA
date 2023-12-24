using System;
using System.Collections;
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

        public bool Search(int needvalue)
        {
            if(head is null)
            {
                throw new Exception("Linked List is empty");
            }
            else
            {
                Node x = head;
                while(x is not null)
                {
                    if(x.value == needvalue)
                    {
                        return true;
                    }
                    x = x.link;

                }
                return false;
            }
        }

        public void InsertNodeAtBeginning(int start)
        {
            if(head is null)
            {
                head = new Node(start);
            }
            else
            {
                var temp = new Node(start);
                temp.link = head;
                head = temp;    
            }

        }


        public void InsertAfter(int data, int needvalue)
        {
            if (head is null)
            {
                throw new Exception("Linked List is empty");
            }
            else
            {
                Node temp = head;
                while (temp is not null)
                {
                    if (temp.value == needvalue)
                    {
                        var nodetoinsert = new Node(data);
                        nodetoinsert.link = temp.link;
                        temp.link = nodetoinsert;

    
                    }
                    temp = temp.link;

                }
            }

        }
    }
}
