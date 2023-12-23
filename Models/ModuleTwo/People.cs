using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class People
    {
        //A propriedade é não anulável, e precisa conter um valor não nulo ao sair do construtor.
        //É possível desativar no arquivo csproj.
        public string Name { get; set; }
        public int Age { get; set; }

        public void Present(){
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}