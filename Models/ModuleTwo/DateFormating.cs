using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class DateFormating
    {
        DateTime date = DateTime.Now;
        public DateFormating() { }

        public void FullDateTime()
        {

            Console.WriteLine(date.ToString());
        }
        public void OnlyDays()
        {

            Console.WriteLine(date.ToShortDateString());
        }
        public void ShortDate()
        {

            Console.WriteLine(date.ToShortTimeString());
        }
        public void ParsingDates()
        {
            string stringDate = "21/12/22";

            bool sucess = DateTime.TryParseExact(stringDate,
                                    "dd/MM/YY",
                                    CultureInfo.InvariantCulture,
                                    DateTimeStyles.None,
                                    out DateTime parsingDate);


            /*TryParseExact Parametros:
            - data para converter
            - formato da data
            - cultura, localização -> caso não tenha invariante
            - estilo da data -> caso não tenha None
            - variável de saída
            */

            if (sucess)
            {

                Console.WriteLine($"Data convertida com sucesso!" + parsingDate);
            }
            else
            {

                Console.WriteLine($"{stringDate} ! A data convertida não é valida");
            }


        }

    }
}