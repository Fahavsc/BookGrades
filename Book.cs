using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        //Fields, Atributos
        private List<double> grades;
        private string name;


        //Construtor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                return;
            }
            this.grades.Add(grade);
        }

        public List<double> getGrades()
        {
            return this.grades;
        }

    }
}
