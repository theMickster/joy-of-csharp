using System;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    public class Developer : Employee, IDeveloper
    {
        public string FavoriteProgrammingLanguage { get; set; }

        public Seniority SeniorityLevel { get; set; }

        public Developer(string firstName, string lastName, Hometown hometown, EmployeeClassification classification, Seniority seniorityLevel) 
            : base(firstName, lastName, hometown, classification)
        {
            SeniorityLevel = seniorityLevel;
        }

        public string GetDetails()
        {
            return base.Display() + Environment.NewLine + $"Seniority: {SeniorityLevel.ToString()} - Favorite Programming Language: {FavoriteProgrammingLanguage}";
        }
    }
}