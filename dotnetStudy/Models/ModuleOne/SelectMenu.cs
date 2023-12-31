using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models
{
    public class SelectMenu
    {
        public void InteractiveMenu()
        {
            string selectedOption;
            bool showMenu = true;

            while (showMenu)
            {
                //evita que o menu se repita a cada opção selecionada
                Console.Clear();


                Console.WriteLine("Digite sua opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");


                selectedOption = Console.ReadLine();

                switch (selectedOption)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Cliente");
                        break;

                    case "2":
                        Console.WriteLine("Busca de Cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        showMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            }
                Console.WriteLine("O programa se encerrou");
        }
    }
}