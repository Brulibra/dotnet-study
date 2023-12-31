using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    class Functions
    {
        public static void HandleFunctions()
        {
            // Solicita o nome do usuário, quilômetros percorridos por dia, 
            // Horas de uso de eletrônicos por dia e o número de refeições com carne:
            string nome = Console.ReadLine();
            double quilometrosPorDia = double.Parse(Console.ReadLine());
            int horasDeEletronicos = int.Parse(Console.ReadLine());
            int refeicoesComCarne = int.Parse(Console.ReadLine());

            // Chama o método para calcular a pegada de carbono
            double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

            //Exiba o resultado para o usuário:
            Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
        }

        //Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
        static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
        {
            double transporte = quilometrosPorDia * 365 * 0.2;
            double eletronicos = horasDeEletronicos * 0.1;
            double consumoDeCarne = refeicoesComCarne * 0.5;

            return transporte + eletronicos + consumoDeCarne;

        }
    }
}
