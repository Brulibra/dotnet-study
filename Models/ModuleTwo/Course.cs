using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class Course
    {
        public string Name { get; set; }
        public List<People> Students { get; set; }

        public void AddStudent(People student)
        {
            Students.Add(student);
        }

        public int AmountOfStudentsEnrolled()
        {
            int amount = Students.Count;
            return amount;
        }

        public bool RemoveStudent(People student)
        {

            return Students.Remove(student);

        }

        public void ListStudents()
        {

            Console.WriteLine($"Alunos do Curso de {Name}");

            for (int counter = 0; counter < Students.Count; counter++)
            {
                //nesse caso é preciso utilizar couter+1 ao invés de courter ++
                //para não alterar o valor da variável contador 
                //sim deixar a leitura mais amigável

                string displayText = $"Nº {counter + 1} - {Students[counter].Fullname}";

                Console.WriteLine(displayText);
            }
        }
    }
}