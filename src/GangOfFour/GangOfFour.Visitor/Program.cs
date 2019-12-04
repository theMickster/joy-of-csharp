using System;
using GangOfFour.Application.Visitors;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Entities.Business;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Visitor");
            Console.WriteLine("");

            var mickDeveloper = new Developer("Mick",
                "Letofsky",
                new Hometown("Aurora",
                    "CO",
                    "USA"),
                EmployeeClassification.FullTimeSalary,
                Seniority.Principal);

            mickDeveloper.UpdateEmployeePayRate(130000);
            mickDeveloper.FavoriteProgrammingLanguage = "T-SQL";
            mickDeveloper.VacationDays = 20;

            var steveDeveloper = new Developer("Steve",
                "Smith",
                new Hometown("San Francisco",
                    "CA",
                    "USA"),
                EmployeeClassification.FullTimeSalary,
                Seniority.Senior);

            steveDeveloper.UpdateEmployeePayRate(125000);
            steveDeveloper.FavoriteProgrammingLanguage = "C#";
            steveDeveloper.VacationDays = 15;

            var peteDeveloper = new Developer("Pete",
                "Jones",
                new Hometown("Omaha",
                    "NE",
                    "USA"),
                EmployeeClassification.FullTimeSalary,
                Seniority.Junior);

            peteDeveloper.UpdateEmployeePayRate(80000);
            peteDeveloper.FavoriteProgrammingLanguage = "JavaScript";
            peteDeveloper.VacationDays = 12;

            var devTeam = new DevelopmentTeam();
            devTeam.Attach(mickDeveloper);
            devTeam.Attach(steveDeveloper);
            devTeam.Attach(peteDeveloper);

            devTeam.Accept(new VacationVisitor(3));

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var employee in devTeam)
            {
                if (employee is Developer developer)
                    Console.WriteLine($"{developer.GetDetails()}");
            }

        }
    }
}
