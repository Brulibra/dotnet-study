/*
Caderno de estudos .NET

Optei por criar todos os exercícios como uma classe independente
e deixar o arquivo Program.cs limpo.

Executando aqui apenas o método que estivesse estudando.
*/

using dotnet_study.Models.ModuleTwo;
ValuesFormatter valuesFormatter = new(value: 82.40M);

valuesFormatter.CurrencyConverter();