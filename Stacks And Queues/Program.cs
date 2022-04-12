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
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.peek();
            stack.pop();
            stack.IsEmpty();
            stack.Display();
            Console.ReadLine();
        }
    }
}
