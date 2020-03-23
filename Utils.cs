using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Utils
    {
        public static double ComputeAverageGrade(List<double> grades)
        {

            var result = 0.0;
            var index = 0;
            //Do While
            do
            {
                result += grades[index];
                index++;
            } while (index < grades.Count);

            return result /= grades.Count;
        }

        public static double GetHighGrade(List<double> grades) 
        {
            if (grades.Count <= 0) throw new ArgumentNullException("Grades está vazio");
            var highGrade = double.MinValue;
            //For comum
            for(int index = 0; index < grades.Count; index++) 
            {
                highGrade = grades[index] > highGrade ?  grades[index] : highGrade;
            }
            return highGrade;
        }

        public static double GetLowGrade(List<double> grades)
        {
            if (grades.Count <= 0) throw new ArgumentNullException("Grades está vazio");
            var lowGrade = double.MaxValue;
            //ForEach
            //foreach (var grade in grades)
            //{
            //    lowGrade = grade < lowGrade ? grade : lowGrade;
            //}
            var index = 0;
            while(index < grades.Count)
            {
                lowGrade = grades[index] < lowGrade ? grades[index] : lowGrade;
                index++;
            }
            return lowGrade;
        }

        public static char ClassifyByGrade(double grade)
        {

            switch(grade)
            {
                case var d when d >= 90.0:
                    return 'A';
                case var d when d >= 80:
                    return 'B';
                case var d when d >= 70:
                    return 'C';
                case var d when d >= 60:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}