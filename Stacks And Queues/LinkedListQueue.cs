using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    class LinkedListQueue
    {
        private Node top;
        public LinkedListQueue()
        {
            this.top = null;
        }
        internal  void Enqueue(int item)
        {
            Node newnode = new Node(item);
            if(this.top==null)
            {
                this.top = newnode;
            }
            else
            {
                Node temp = this.top;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;  
            }
            Console.WriteLine("{0} is inserted into Queue", newnode.data);
        }
        internal void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.top;
            if(temp==null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
