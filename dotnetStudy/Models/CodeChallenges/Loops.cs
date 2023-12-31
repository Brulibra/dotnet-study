using System;

class Loops
{
    public static void HandleLoops()
    {
        // Solicita ao usuário os limites inferiores e superiores
        int limiteInferior = int.Parse(Console.ReadLine());
        int limiteSuperior = int.Parse(Console.ReadLine());

        // Variável para acumular a soma dos números pares
        int somaPares = 0;

        // Crie um Loop para percorrer os números no intervalo
        // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            // Implemente o if para verificar se o número é par:
            if (i % 2 == 0)
            {
                // Crie o acumulador para a soma dos números pares:
                somaPares = somaPares + i;
            }
        }
        // Exibe o resultado
        Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}