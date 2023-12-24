using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Node
    {
        public Node link;
        public int value;

        public Node(int value) 
        {
            this.link = null;
            this.value = value;     
        }   
    }
}
