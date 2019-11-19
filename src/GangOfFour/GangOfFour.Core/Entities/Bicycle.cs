using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    /// <summary>
    /// Class representing a complex product.
    /// Used in the Builder pattern.
    /// </summary>
    public class Bicycle : IBicycle
    {
        private LinkedList<BicyclePart> _assembledBicycleParts = new LinkedList<BicyclePart>();

        public bool IsAssembled { get; private set; }

        public bool IsReadyForCustomer { get; private set; }

        public string Name { get; private set; }

        public BicycleType BicycleType { get; private set; }

        public void Add(BicyclePart bicyclePart)
        {
            _assembledBicycleParts.AddLast(bicyclePart);
        }

        public string ListAssembledParts()
        {
            return _assembledBicycleParts.Aggregate(string.Empty,
                (current,bicyclePart) => current + (Environment.NewLine + $"Id: {bicyclePart.Id} - Name: {bicyclePart.Name}"));
        }

        public void BikeIsAssembled()
        {
            // In a more complex class, we would perform additional complex validation or logging prior to flagging as complete.
            IsAssembled = true;
        }

        public void BikeIsReadyForCustomer()
        {
            // In a more complex class, we would perform additional complex validation or logging prior to flagging as complete.
            IsReadyForCustomer = true;
        }

        public void UpdateBicycleName(string name)
        {
            Name = name;
        }

        public void UpdateBicycleBicycleType(BicycleType type)
        {
            BicycleType = type;
        }
    }
}