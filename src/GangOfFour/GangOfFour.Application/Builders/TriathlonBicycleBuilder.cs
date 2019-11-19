using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Builders
{
    public class TriathlonBicycleBuilder: BicycleBuilder, IBicycleBuilder
    {
        public TriathlonBicycleBuilder()
        {
            Bicycle.UpdateBicycleBicycleType(BicycleType.Triathlon);
        }

        public void InstallSeatPost()
        {
            Bicycle.Add(new BicyclePart { Id = 101, Name = "Seat Post" });
        }

        public void InstallHeadSet()
        {
            Bicycle.Add(new BicyclePart { Id = 102, Name = "Headset" });
        }

        public void InstallFork()
        {
            Bicycle.Add(new BicyclePart { Id = 103, Name = "Fork" });
        }

        public void InstallBottomBracket()
        {
            Bicycle.Add(new BicyclePart { Id = 104, Name = "Bottom Bracket" });
        }

        public void InstallCranks()
        {
            Bicycle.Add(new BicyclePart { Id = 105, Name = "Cranks" });
        }

        public void InstallPedals()
        {
            Bicycle.Add(new BicyclePart { Id = 106, Name = "Pedals" });
        }

        public void InstallCableGuide()
        {
            Bicycle.Add(new BicyclePart { Id = 107, Name = "Cable Guide" });
        }

        public void InstallDerailleur()
        {
            Bicycle.Add(new BicyclePart { Id = 108, Name = "Derailleur" });
        }

        public void InstallBrakes()
        {
            Bicycle.Add(new BicyclePart { Id = 109, Name = "Brakes" });
        }

        public void InstallChain()
        {
            Bicycle.Add(new BicyclePart { Id = 110, Name = "Chain" });
        }

        public void InstallCables()
        {
            Bicycle.Add(new BicyclePart { Id = 111, Name = "Cables" });
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
            return Bicycle.IsReadyForCustomer ? Bicycle : null ;
        }
    }
}