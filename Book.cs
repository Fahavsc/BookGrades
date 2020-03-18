using System;
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

        public void ShowStatistics()
        {
            var averageGrade = Utils.ComputeAverageGrade(this.grades);
            var highGrade = Utils.GetHighGrade(this.grades);
            var lowGrade = Utils.GetLowGrade(this.grades);

            Console.WriteLine($"\nEstatisticas das notas do(a) aluno(a) {this.name}");
            Console.WriteLine($"\nA media das de notas é: {averageGrade}");
            Console.WriteLine($"\nA menor nota é: {lowGrade}");
            Console.WriteLine($"\nA maior nota é: {highGrade}");
        }

    }
}
