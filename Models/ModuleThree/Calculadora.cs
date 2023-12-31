using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_study.Interface;

namespace dotnet_study.Models.ModuleThree
{
    public class Calculadora : ICalculadora
    {

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        
        //Quando a implementação existe na interface o método se torna opcional

        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2;
        // }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}