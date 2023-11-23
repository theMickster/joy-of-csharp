using System;
using System.Threading;
using System.Threading.Tasks;
using GangOfFour.Application.Mementos;
using GangOfFour.Core.Entities;

namespace GangOfFour.Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Momento");
            Console.ForegroundColor = ConsoleColor.White;

            var originator01 = new Book {Author = "Fernández Muñoz Santiago", Title = "Exam Ref AZ-2030 Developing Solutions for Microsoft Azure", Isbn = "978-0-13-564380-8" };
            var originator02 = new Book { Author = "Miles Rob", Title = "Exam Ref 70-4830 Programming in C##", Isbn = "978-1-5093-0698-5" };

            var caretaker01 = new BookCaretaker(originator01);
            var caretaker02 = new BookCaretaker(originator02);
            
            // Quick sleep to ensure we see a noticeable last updated date....
            Thread.Sleep(2000);

            caretaker01.Backup();
            caretaker02.Backup();

            originator01.Author = "Santiago Fernández Muñoz";
            caretaker01.Backup();

            Thread.Sleep(2000);

            originator02.Author = "Rob Miles";
            caretaker02.Backup();

            Thread.Sleep(2000);

            originator02.Title = "Exam Ref 70-483 Programming in C#";
            caretaker02.Backup();


            originator01.Title = "Exam Ref AZ-203 Developing Solutions for Microsoft Azure";
            caretaker01.Backup();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            caretaker01.ShowHistory();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            caretaker02.ShowHistory();


        }
    }
}
