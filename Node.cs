using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDLL
{
    internal class Node
    {
        public String data ;
        public Node next;
        public Node prev;
        public Node(String data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
