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

            Console.WriteLine("Insira seu nome:");
            var name = Console.ReadLine();
            var book = new Book(name);
            book.GradeAdded += OnGradeAdded;
            //ou (object sender, EventArgs e) => { };
            do
            {
                var input = "";
                Console.WriteLine("\nInsira uma nota entre 0 e 100:");
                Console.WriteLine("\nPara sair digite Q e pressione enter");
                input = Console.ReadLine();
                if (!("q".Equals(input)) && !("Q".Equals(input)))
                {
                    try
                    {
                        var grade = Double.Parse(input);
                        book.AddGrade(grade);
                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                    }
                    catch(ArgumentException aex)
                    {
                        Console.WriteLine(aex.Message);
                    }
                    catch (FormatException afe)
                    {
                        Console.WriteLine(afe.Message);
                    }
                    
                }
                else
                {
                    break;
                }                 

            } while (true); ;
            try { 
                book.ShowStatistics();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was Added");
        }
    }
}
