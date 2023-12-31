using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models
{
    public class MultiplicationsTablesMethods
    {
        public void ForMathTable(int x)
        {
            for (int num = 0; num <= 10; num++)
            {
                Console.WriteLine($"{x} x {num} = {x * num}");
            }
        }

        public void WhileMathTable(int x)
        {
            int num = 0;
            while (num <= 10)
            {

                Console.WriteLine($"{x} x {num} = {x * num}");

                num++;

                if (num == 5) break;

            }
        }
        public void DoWhileMathTable()
        {
            int num = 0;
            int sum = 0;

            do
            {
                Console.WriteLine($"Digite um número 0 para encerrar o programa");

                num = Convert.ToInt32(Console.ReadLine());

                sum += num;

            } while (num != 0);

            Console.WriteLine($"Total da soma dos números digitados é {sum}");
        }
    }
}