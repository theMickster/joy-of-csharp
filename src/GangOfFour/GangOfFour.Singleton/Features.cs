using System;
using System.Collections;
using System.Collections.Generic;
using GangOfFour.Core.Entities;

namespace GangOfFour.Singleton
{
    public sealed class Features : IEnumerable<FeatureFlag>
    {
        private static readonly Features _instance = new Features();

        private readonly IList<FeatureFlag> _featureFlags;

        private Features()
        {
            _featureFlags = new List<FeatureFlag>
            {
                new FeatureFlag{Id = Guid.NewGuid(), Name = "Student Search", Enabled = true},
                new FeatureFlag{Id = Guid.NewGuid(), Name = "Course Search", Enabled = true},
                new FeatureFlag{Id = Guid.NewGuid(), Name = "Instructor Search", Enabled = false},
                new FeatureFlag{Id = Guid.NewGuid(), Name = "Course to Instructor Mapping", Enabled = true},
                new FeatureFlag{Id = Guid.NewGuid(), Name = "ASP.NET Core Identity", Enabled = false}
            };
        }

        public static Features GetFeatures()
        {
            return _instance;
        }

        public IEnumerator<FeatureFlag> GetEnumerator()
        {
            return _featureFlags.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}