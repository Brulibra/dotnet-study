using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleThree
{
    //abstract -> este método é apenas para ser herdado
    public abstract class Conta
    {
        protected decimal saldo;
        //protegido de alterações externas,
        //com exceção de suas classes filhas
        public abstract void Creditar(decimal valor);
        //o método abstract Creditar não possui corpo
        //e deve obrigatóriamente ser herdado

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo}");
        }
    }
}