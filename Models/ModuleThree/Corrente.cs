using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleThree
{
    public class Corrente : Conta
    {
        //implementei o método Creditar
        //obedeci as regras da classe abstrata
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}