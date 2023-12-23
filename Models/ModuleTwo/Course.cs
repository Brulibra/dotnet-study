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

        /*
        Um método possuí algumas sessões características:
        void -> não preciso, não espero nenhum retorno
        NomeMétodo -> nome do método literalmente...
        (Tipo parâmetro) -> Tipo, classe de onde vem o dado, variável que indica o aluno
        */
        public void AddStudent(People student)
        {
            Students.Add(student);
        }

        /*
        Via de regra, todo étodo diferente de void,
        espera um retorno, e não necessáriamente 
        espera um argumento
        */
        public int AmountOfStudentsEnrolled()
        {
            int amount = Students.Count;
            return amount;
        }

        public bool RemoveStudent(People student)
        {

            //o proprio método remove retorna um bool
            //true em caso de sucesso, false em caso de erro
            return Students.Remove(student);

        }

        public void ListStudents()
        {
            foreach (People student in Students)
            {
                Console.WriteLine(student.Fullname);
            }
        }
    }
}