using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    class Array
    {
        public static void HandleArray()
        {
            // Pergunta ao usuário quantos jogos deseja adicionar:
            int quantidadeJogos = int.Parse(Console.ReadLine());

            //Inicializa os arrays com base na quantidade informada pelo usuário:
            string[] nomesJogos = new string[quantidadeJogos];

            //Crei um Loop para adicionar jogos conforme a quantidade especificada:
            for (int i = 0; i < quantidadeJogos; i++)
            {
                //Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:

                AdicionarJogo(indice: i, nomes: nomesJogos);
            }

            // Exibe o resumo da adição de jogos
            ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
        }

        static void AdicionarJogo(int indice, string[] nomes)
        {
            // Entrada do nome do jogo
            nomes[indice] = Console.ReadLine();
        }

        static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
        {
            string resumoJogos = "";
            for (int i = 0; i < quantidadeJogos; i++)
            {
                resumoJogos += $"{nomes[i]}";
                if (i < nomes.Length - 1)
                {
                    resumoJogos += ", ";
                }
            }
            Console.WriteLine($"Foi adicionado {quantidadeJogos} jogos: {resumoJogos} ao catalogo.");
        }
    }
}
