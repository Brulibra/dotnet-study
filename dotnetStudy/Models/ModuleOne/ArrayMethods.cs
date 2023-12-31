using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models
{
    public class ArrayMethods
    {
        /*
        declarando um array de 3  posições
        uma vez declarado, esse valor não pode ser alterado
        */
        int[] arrayRealNumbers = new int[3];

        public void ArrayFor()
        {

            /*
            arrayInteiros na posição [X]
            recebe (=) valor Y
            */
            arrayRealNumbers[0] = 21;
            arrayRealNumbers[1] = 23;
            arrayRealNumbers[2] = 25;


            int[] longArrayRealNumber = new int[arrayRealNumbers.Length * 2];
            Array.Copy(arrayRealNumbers, longArrayRealNumber, arrayRealNumbers.Length);

            Console.WriteLine("Percorrendo com For");

            for (int counter = 0; counter < arrayRealNumbers.Length; counter++)
            {
                Console.WriteLine($"Posição {counter} - Nº {arrayRealNumbers[counter]}");
            }
        }
        public void ArrayForEach()
        {
            arrayRealNumbers[0] = 22;
            arrayRealNumbers[1] = 24;
            arrayRealNumbers[2] = 26;

            Console.WriteLine("Percorrendo com ForEach");

            foreach (int value in arrayRealNumbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}