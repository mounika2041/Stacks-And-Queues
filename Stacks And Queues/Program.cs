using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stacks and Queues");
            LinkedListQueue Queue = new LinkedListQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();
            Console.ReadLine();
        }
    }
}
