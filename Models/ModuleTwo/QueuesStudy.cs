using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class QueuesStudy
    {
        Queue<int> line = new Queue<int>();
        public void HandleQueue()
        {
            line.Enqueue(2);
            line.Enqueue(4);
            line.Enqueue(6);
            line.Enqueue(8);

            foreach (int num in line)
            {
                Console.WriteLine(num);
            }

            //Por regra SEMPRE remove o primeiro elemento -> FIFO
            
            Console.WriteLine($"Removendo o elemento: {line.Dequeue()}");

            foreach (int num in line)
            {
                Console.WriteLine(num);
            }
        }
    }
}