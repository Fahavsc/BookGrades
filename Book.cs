using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        //Fields, Atributos
        private List<double> grades;
        private string name;
        private Statistics stats;

        //Construtor
        public Book(string name)
        {
            grades = new List<double>();
            stats = new Statistics();
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

        public List<double> GetGrades()
        {
            return this.grades;
        }

        public Statistics GetStatistics()
        {
            SetStatistics();
            return this.stats;
        }

        private void SetStatistics()
        {
            this.stats.Average = Utils.ComputeAverageGrade(this.grades);
            this.stats.High = Utils.GetHighGrade(this.grades);
            this.stats.Low = Utils.GetLowGrade(this.grades);
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"\nEstatisticas das notas do(a) aluno(a) {this.name}");
            Console.WriteLine($"\nA media das de notas é: {this.stats.Average}");
            Console.WriteLine($"\nA menor nota é: {this.stats.Low}");
            Console.WriteLine($"\nA maior nota é: {this.stats.High}");
        }
    }
}
