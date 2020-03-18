using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
       
        static void Main(string[] args)
        {
              
            var book = new Book("Fabricio");
            //var numbers = new[] { 1.3, 10.2, 13.3, 10 };
            //var grades = new List<double>() { 8, 7.3, 9.12, 5.231 };
            //book.AddGrade(90.3);
            //book.AddGrade(74);
            //book.AddGrade(29.3);
            //book.AddGrade(80.2);

            var result = Utils.ComputeAverageGrade(book.getGrades());
            var highGrade = Utils.GetHighGrade(book.getGrades());
            Utils.ShowGrades(book.getGrades());
            Console.WriteLine($"\nA media é {result:N2} e a maior nota foi {highGrade:N2}");
            //if (args.Length>0)
            //{
            //    Console.WriteLine($"Bem vindo {args[0]}");
            //}else
            //{
            //    Console.WriteLine("Digite seu nome");
            //    var a = Console.ReadLine();
            //    Console.WriteLine($"Olá, {a}!");
            //}
        }
    }
}
