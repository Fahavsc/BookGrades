using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        //Fields, Atributos
        private List<double> grades;
        private Statistics stats;
        //readonly string category = "Ciencias";   //Só pode ser alterado no construtor ou na forma que está explicita ao lado (Criando e inicializando a variável)

        public const string CATEGORY = "Ciencias"; //Variavel deve ser inicializada assim que declarada e não podera ser alterada de outra forma 
                                                   //Campos Const são tratados externamente como campos estaticos, deve se o usar o tipo da classe para fazer referencia ao memsmo
        
        //Construtor
        public Book(string name)
        {
            
            grades = new List<double>();
            stats = new Statistics();
            this.Name = name;
        }

        public string Name
        {
            //get
            //{
            //    return this.name;
            //}
            //set
            //{
            //    //Setters no C# possuem um valor value encapsulado o qual não necessita ser passado por parametro
            //    //Quando é feita uma atribuição ao Name o proprio compilador interpreata que o Seter esta sendo chamado e realiza as ações que estiverem dentro do Bloco Set
            //    if (!String.IsNullOrEmpty(value)) 
            //        name = value;                 
            //    else
            //        throw new ArgumentNullException($"{nameof(value)} não pode ser Null ou vazio : {value}");
            //}
            get; set;
        }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public void AddGrade(char letter)
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
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
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