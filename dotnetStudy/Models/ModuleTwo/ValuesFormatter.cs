using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_study.Models.ModuleTwo
{
    public class ValuesFormatter
    {
        public ValuesFormatter() { }
        public ValuesFormatter(decimal money, string region)
        {
            Value = money;
            Region = region;
        }
        private decimal _money;
        private string _region;
        public decimal Value { get => _money; set => _money = value; }
        public string Region { get => _region; set => _region = value; }

        public void CurrencyConverter()
        {
            Console.WriteLine(Value.ToString("C",
            CultureInfo.CreateSpecificCulture(Region)
            ));
        }
    }
}