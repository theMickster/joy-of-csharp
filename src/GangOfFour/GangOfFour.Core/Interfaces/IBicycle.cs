using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Core.Interfaces
{
    public interface IBicycle
    {
        void Add(BicyclePart bicyclePart);

        string ListAssembledParts();

        void BikeIsAssembled();

        void BikeIsReadyForCustomer();

        void UpdateBicycleName(string name);

        void UpdateBicycleBicycleType(BicycleType type);
    }
}