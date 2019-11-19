using System;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    public abstract class Employee : Person, IEmployee
    {
        public EmployeeClassification Classification { get; set; }

        public string Role { get; set; }

        public int PayRate { get; private set; }

        protected Employee(string firstName, string lastName, Hometown hometown, EmployeeClassification classification) 
            : base(firstName, lastName, hometown)
        {
            Classification = classification;
        }

        public void UpdateEmployeePayRate(int payRate)
        {
            if (payRate <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(payRate), "Pay rate must be greater than zero.");
            }
            if (payRate > 250000 && Classification == EmployeeClassification.FullTimeSalary)
            {
                throw new ArgumentOutOfRangeException(nameof(payRate), "Pay rate cannot be greater than $250K for a full time employee.");
            }
            if (payRate > 100000 && Classification == EmployeeClassification.PartTimeSalary)
            {
                throw new ArgumentOutOfRangeException(nameof(payRate), "Pay rate cannot be greater than $100K for a full time employee.");
            }
            if (payRate > 150 && Classification == EmployeeClassification.Hourly)
            {
                throw new ArgumentOutOfRangeException(nameof(payRate), "Pay rate cannot be greater than $150 per hour for an hourly employee.");
            }

            PayRate = payRate;
        }

        public virtual IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public new string Display()
        {
            return base.Display() + Environment.NewLine + $"Pay Rate: {PayRate}";
        }
    }
}