using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class Dictionary
    {
        //Dicionário -> uma coleção de chave-valor, para armazenar
        //dados específicos SEM ordem específica

        Dictionary<string, string> states = new Dictionary<string, string>();
        public void ListStates()
        {
            states.Add("SP", "São Paulo");
            states.Add("BA", "Bahia");
            states.Add("MG", "Minas Gerais");

            foreach (KeyValuePair<string, string> UF in states)
            {
                Console.WriteLine($"Chave: {UF.Key}, Valor: {UF.Value}");
            }
        }

        public void RomoveState(string key)
        {
            states.Add("SP", "São Paulo");
            states.Add("BA", "Bahia");
            states.Add("MG", "Minas Gerais");

            Console.WriteLine($"Removendo estado {states.Remove(key)}");

        }

        public void SearchKey(string key)
        {
            states.Add("SP", "São Paulo");
            states.Add("BA", "Bahia");
            states.Add("MG", "Minas Gerais");

            Console.WriteLine($"Verificando o elemento: {key}");

            if (states.ContainsKey(key))
            {
                Console.WriteLine($"Valor Existente: {key}");
            }
            else
            {
                Console.WriteLine($"Volor não existe. é seguro adcionar a chave {key}");
            }
        }
    }
}