using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleThree
{
    public class Aluno : Pessoa
    {
        //O construtor vazio é a solução para a prop ser opcional
        public Aluno() { }
        //Aluno também recebe um construtor
        public Aluno(string nome) : base(nome)
        {
            //não passo nada no nome, pois o parâmetro que passo aqui
            //será passado para a classe mãe
        }

        public int Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade}, e sou um aluno nota {Nota}");
        }
    }
}