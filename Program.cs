/*
Caderno de estudos .NET

Optei por criar todos os exercícios como uma classe independente
e deixar o arquivo Program.cs limpo.

Executando aqui apenas o método que estivesse estudando.
*/

using dotnet_study.Models.ModuleTwo;
//Usando o construtor para passar o nome e sobrenome
People people = new(name: "Bruna", lastname: "de Paula");
People people2 = new(name: "Ana", lastname: "Prado");

Course englishCourse = new();
//----

englishCourse.Name = "Inglês";
englishCourse.Students = new List<People>();

englishCourse.AddStudent(people);
englishCourse.AddStudent(people2);

englishCourse.ListStudents();