using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class People
    {
        /*características do construtor
        - Tem o mesmo nome da Classe
        - Não possue retorno
        - É preciso atribuir valor à variável no construtor também
        
        NOTA: Caso os valores sejam passados depois,
        é possível criar um 2º construtor.
        Não há limites de construtores para uma classe
        */
        public People(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
        public People() { }

        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Por favor, insira o nome");
                }
                _name = value;
            }

        }
        private string _lastname;
        public string Lastname { get => _lastname; set => _lastname = value; }

        public string Fullname => $"{Name} {Lastname}".ToUpper();

        private int _age;
        public int Age
        {
            get => _age;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que 0");
                }
                _age = value;
            }
        }

        public void Present()
        {
            Console.WriteLine($"Nome: {Fullname}, Idade: {Age}");
        }
    }
}