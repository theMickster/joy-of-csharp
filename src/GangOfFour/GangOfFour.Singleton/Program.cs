using System;
using GangOfFour.Core.Entities;

namespace GangOfFour.Singleton
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Singleton");

            Features featuresInstance01 = Features.GetFeatures();
            Features featuresInstance02 = Features.GetFeatures();
            Features featuresInstance03 = Features.GetFeatures();

            if (featuresInstance01 == featuresInstance02 && featuresInstance02 == featuresInstance03 &&
                featuresInstance01 == featuresInstance03)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("All instances of the Feature class are the same instance.");
            }

            Console.ForegroundColor = ConsoleColor.White;

            foreach (FeatureFlag feature in featuresInstance01)
            {
                Console.WriteLine($"Feature Flag: Id => {feature.Id.ToString()}  - Name {feature.Name}   - IsEnabled? {feature.Enabled.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
