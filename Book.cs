using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        //Fields, Atributos
        private List<double> grades;
        public string Name;
        private Statistics stats;

        //Construtor
        public Book(string name)
        {
            grades = new List<double>();
            stats = new Statistics();
            this.Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double nota)
        {
            if (nota <= 100 && nota >= 0)
            {
                this.grades.Add(nota);
            }else
            {
                throw new ArgumentException($"Valor da {nameof(nota)} inválido : {nota}");
            }
            
        }

        public int GetNumberOfGrades()
        {
            return this.grades.Count;
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
            if (this.grades.Count > 0)
            {
                this.stats.Average = Utils.ComputeAverageGrade(this.grades);
                this.stats.High = Utils.GetHighGrade(this.grades);
                this.stats.Low = Utils.GetLowGrade(this.grades);
                this.stats.Letter = Utils.ClassifyByGrade(this.stats.Average);
            }
        }

        public void ShowStatistics()
        {
            if (this.grades.Count > 0)
            {
                Console.Clear();
                SetStatistics();
                Console.WriteLine($"\nEstatisticas das notas do(a) aluno(a) {this.Name}");
                Console.WriteLine($"\nA media das de notas é: {this.stats.Average}");
                Console.WriteLine($"\nA menor nota é: {this.stats.Low}");
                Console.WriteLine($"\nA maior nota é: {this.stats.High}");
                Console.WriteLine($"\nClassificação: {this.stats.Letter}");
            }
            else
            {
                throw new ArgumentNullException($"{nameof(this.grades.Count)} está sem nenhuma nota preenchida");
            }
        }
        
    }
}