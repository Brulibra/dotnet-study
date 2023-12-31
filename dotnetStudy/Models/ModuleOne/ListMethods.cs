using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models
{
    public class ListMethods
    {
        public void StringList()
        {
            List<string> listString = new List<string>();

            listString.Add("SP");
            listString.Add("BA");
            listString.Add("MG");

            //Count equiva ao Length
            //Da mesma forma que com array
            //se passa o índice na lista

            Console.WriteLine($"Percorrendo com Laço For ");

            for (int counter = 0; counter < listString.Count; counter++)
            {
                Console.WriteLine($"{counter} - {listString[counter]}");
            }

            Console.WriteLine($"Percorrendo com Laço For Each");
            int counterForEach = 0;

            foreach (string item in listString)
            {

                Console.WriteLine($"{counterForEach} - {item}");
                counterForEach++;

            }

        }
    }
}