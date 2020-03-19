using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // var numbers = new[] { 1.3, 10.2, 13.3, 10 };
            //var grades = new List<double>() { 8, 7.3, 9.12, 5.231 }; 

            var book = new Book("Fabricio");
            book.AddGrade(90.3);
            book.AddGrade(74);
            book.AddGrade(29.3);
            book.AddGrade(54);
            book.ShowStatistics();
        }
    }
}
