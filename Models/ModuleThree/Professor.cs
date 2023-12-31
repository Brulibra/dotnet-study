using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleThree
{
    public class Professor : Pessoa
    {
        //O construtor vazio é a solução para a prop ser opcional
        public Professor() { }
        //Professor também recebe um construtor
        public Professor(string nome) : base(nome)
        {
            //não passo nada no nome, pois o parâmetro que passo aqui
            //será passado para a classe mãe
        }

        public int Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade}, e ganho {Salario}");
        }
    }
}