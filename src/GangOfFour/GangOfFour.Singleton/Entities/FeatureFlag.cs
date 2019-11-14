using System;

namespace GangOfFour.Singleton.Entities
{
    public class FeatureFlag
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public Boolean Enabled { get; set; }
    }
}