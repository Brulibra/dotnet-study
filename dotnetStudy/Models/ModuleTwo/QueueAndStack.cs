using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class QueueAndStack

    {
        Queue<int> line = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        public void HandleQueue()
        {
            line.Enqueue(2);
            line.Enqueue(4);
            line.Enqueue(6);
            line.Enqueue(8);

            foreach (int num in line)
            {
                Console.WriteLine("Queue " + num);
            }

            //Por regra SEMPRE remove o primeiro elemento -> FIFO

            Console.WriteLine($"Removendo o elemento: {line.Dequeue()}");

            foreach (int num in line)
            {
                Console.WriteLine("Queue " + num);
            }
        }
        public void HandleStack()
        {
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);

            foreach (int num in stack)
            {
                Console.WriteLine("Stack " + num);
            }

            Console.WriteLine($"Removendo elemento do topo: {stack.Pop()}");

            foreach (int num in stack)
            {
                Console.WriteLine("Stack " + num);
            }
        }
    }

}