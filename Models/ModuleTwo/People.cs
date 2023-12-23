using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class People
    {
        //O campo private irá guardar o valor do nome
        //um dos pilares da OOP é proteger os atributos de modificações externas
        //a não ser que eles passem por validações

        private string _name;
        public string Name
        {
            get => _name.ToUpper();
            //retorna o nome em caixa alta

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Por favor, insira o nome")
                    //caso caia na execão, o programa se encerra
;
                }
                //caso o valor esteja preenchido, salva no campo _name
                _name = value;
            }



        }
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
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}