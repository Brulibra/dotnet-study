using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class ValuesFormatter
    {
        public ValuesFormatter(decimal value)
        {
            Value = value;
        }
        public ValuesFormatter() { }
        private decimal _value;
        public decimal Value { get => _value; set => _value = value; }

        public void CurrencyConverter(){
            Console.WriteLine($"{Value:C}");
        }
    }
}