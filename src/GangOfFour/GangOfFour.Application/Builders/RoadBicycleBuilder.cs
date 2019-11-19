using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Builders
{
    public class RoadBicycleBuilder : BicycleBuilder, IBicycleBuilder
    {
        public RoadBicycleBuilder()
        {
            Bicycle.UpdateBicycleBicycleType(BicycleType.Road);
        }

        public void InstallSeatPost()
        {
            Bicycle.Add(new BicyclePart{Id = 1, Name = "Seat Post"});
        }

        public void InstallHeadSet()
        {
            Bicycle.Add(new BicyclePart { Id = 2, Name = "Headset" });
        }

        public void InstallFork()
        {
            Bicycle.Add(new BicyclePart { Id = 3, Name = "Fork" });
        }

        public void InstallBottomBracket()
        {
            Bicycle.Add(new BicyclePart { Id = 4, Name = "Bottom Bracket" });
        }

        public void InstallCranks()
        {
            Bicycle.Add(new BicyclePart { Id = 5, Name = "Cranks" });
        }

        public void InstallPedals()
        {
            Bicycle.Add(new BicyclePart { Id = 6, Name = "Pedals" });
        }

        public void InstallCableGuide()
        {
            Bicycle.Add(new BicyclePart { Id = 7, Name = "Cable Guide" });
        }

        public void InstallDerailleur()
        {
            Bicycle.Add(new BicyclePart { Id = 8, Name = "Derailleur" });
        }

        public void InstallBrakes()
        {
            Bicycle.Add(new BicyclePart { Id = 9, Name = "Brakes" });
        }

        public void InstallChain()
        {
            Bicycle.Add(new BicyclePart { Id = 10, Name = "Chain" });
        }

        public void InstallCables()
        {
            Bicycle.Add(new BicyclePart { Id = 11, Name = "Cables" });
        }

        public override void BicycleAssemblyIsComplete()
        {
            // In a more complex sub-class, additional logic could be done here that is different from other Bicycle Builder subclasses....
            Bicycle.BikeIsAssembled();
        }

        public override void BicycleTestRideIsComplete()
        {
            // In a more complex sub-class, additional logic could be done here that is different from other Bicycle Builder subclasses....
            Bicycle.BikeIsReadyForCustomer();
        }

        public IBicycle DeliverBicycle()
        {
            // Potential for Null Object Pattern.
            return Bicycle.IsReadyForCustomer ? Bicycle : null;
        }

    }
}