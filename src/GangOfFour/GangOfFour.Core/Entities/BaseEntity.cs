using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GangOfFour.Core.Entities
{
    public abstract class BaseEntity : IValidatableObject
    {
        public int Id { get; set; }

        public DateTime ModifiedDate { get; private set; } = DateTime.Now;

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }

        public void UpdateModifiedDate(DateTime date)
        {
            if (date > ModifiedDate)
                ModifiedDate = date;
        }
    }
}