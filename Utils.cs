using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Utils
    {
        public static double ComputeAverageGrade(List<double> grades)
        {

            var result = 0.0;
            foreach (var grade in grades)
            {
                result += grade;
            }

            return result /= grades.Count;
        }

        public static double GetHighGrade(List<double> grades) 
        {
            if (grades.Count <= 0) throw new ArgumentNullException("Grades está vazio");
            var highGrade = double.MinValue;
            foreach (var grade in grades)
            {
                highGrade = grade > highGrade ?  grade : highGrade;
            }
            return highGrade;
        }

        public static void ShowGrades(List<double> grades)
        {
            if (grades.Count <= 0)
            {
                Console.WriteLine("Não há nenhuma nota para ser exibida");
                return;//Verifica se grade é menor que zero se sim não executa
            }
            Console.WriteLine("Notas registradas:");
            foreach (var grade in grades)
            {
                Console.WriteLine($"\nNota: {grade}");
            }
        }
    }
}
