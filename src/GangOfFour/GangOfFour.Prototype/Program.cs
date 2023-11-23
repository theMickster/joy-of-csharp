using System;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Entities.Business;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Prototype");
            Console.ForegroundColor = ConsoleColor.White;

            var mickDeveloper = new Developer("Mickey",
                "Letofskyy",
                new Hometown("Aurora",
                    "CO",
                    "USA"),
                EmployeeClassification.FullTimeSalary,
                Seniority.Principal);

            mickDeveloper.UpdateFirstName("Mick");
            mickDeveloper.UpdateLastName("Letofsky");
            mickDeveloper.UpdateEmployeePayRate(130000);
            mickDeveloper.FavoriteProgrammingLanguage = "T-SQL";

            var joeDeveloper = (Developer)mickDeveloper.Clone();
            joeDeveloper.FavoriteProgrammingLanguage = "C#";
            joeDeveloper.SeniorityLevel = Seniority.Senior;
            joeDeveloper.UpdateEmployeePayRate(115000);
            joeDeveloper.UpdateFirstName("Joe");
            joeDeveloper.UpdateLastName("Doe");

            Console.WriteLine();
            Console.WriteLine(mickDeveloper.GetDetails());
            Console.WriteLine();
            Console.WriteLine(joeDeveloper.GetDetails());
            Console.WriteLine();

            var isSameObject = mickDeveloper.Hometown == joeDeveloper.Hometown;
            Console.WriteLine($"Are developer hometown's the same object? {isSameObject.ToString()}");

            joeDeveloper.Hometown = new Hometown("Broomfield", "CO", "USA");

            Console.WriteLine();
            Console.WriteLine(joeDeveloper.GetDetails());
            Console.WriteLine();

            isSameObject = mickDeveloper.Hometown == joeDeveloper.Hometown;
            Console.WriteLine($"Are developer hometown's the same object? {isSameObject.ToString()}");

            Console.ReadKey();

        }
    }
}
