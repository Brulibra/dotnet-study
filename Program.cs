/*
Caderno de estudos .NET

Optei por criar todos os exercícios como uma classe independente
e deixar o arquivo Program.cs limpo.

Executando aqui apenas o método que estivesse estudando.
*/

using dotnet_study.Models.ModuleTwo;
//Duas instândias da Classe Pessoa
People people = new();
People people2 = new();

Course englishCourse = new();

people.Name = "Bruna";
people.Lastname = "de Paula";

people2.Name = "Ana";
people2.Lastname = "Prado";
//----

//Nova instancia da classe curso -> Inglês
englishCourse.Name = "Inglês";
englishCourse.Students = new List<People>();
//Add pessoas/alunos
englishCourse.AddStudent(people);
englishCourse.AddStudent(people2);
//lista alunos
englishCourse.ListStudents();