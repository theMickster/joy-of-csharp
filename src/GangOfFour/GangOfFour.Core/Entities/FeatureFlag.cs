using System;

namespace GangOfFour.Core.Entities
{
    public class FeatureFlag
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public Boolean Enabled { get; set; }
    }
}