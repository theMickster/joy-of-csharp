using System;
using System.Text.RegularExpressions;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Business
{
    public abstract class Person : IPerson
    {
        private const string _pattern = "^[a-zA-Z]*$";
        private readonly Regex _regex; 

        protected Person(string firstName, string lastName, Hometown hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Hometown = hometown;
            _regex = new Regex(_pattern);
        }
        
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Hometown Hometown { get; set; }

        public virtual string Display()
        {
            return $"{LastName},{FirstName} - Hometown: {Hometown.City}, {Hometown.StateProvinceRegion}";
        }

        public void UpdateFirstName(string updatedFirstName)
        {
            if (updatedFirstName.Length < 3)
            { 
                throw new ArgumentOutOfRangeException(nameof(updatedFirstName),
                    "A first name must be greater than 3 characters.");
            }

            if (!_regex.IsMatch(updatedFirstName))
            {
                throw new ArgumentException("A first name must only contain alpha-numeric characters.", nameof(updatedFirstName));
            }

            FirstName = updatedFirstName;
        }

        public void UpdateLastName(string updatedLastName)
        {
            if (updatedLastName.Length < 3)
            {
                throw new ArgumentOutOfRangeException(nameof(updatedLastName),
                    "A last name must be greater than 3 characters.");
            }

            if (!_regex.IsMatch(updatedLastName))
            {
                throw new ArgumentException("A last name must only contain alpha-numeric characters.", nameof(updatedLastName));
            }

            LastName = updatedLastName;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}