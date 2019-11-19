﻿using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Builders
{
    public class MountainBicycleBuilder : BicycleBuilder, IBicycleBuilder
    {
        public MountainBicycleBuilder()
        {
            Bicycle.UpdateBicycleBicycleType(BicycleType.Mountain);
        }

        public void InstallSeatPost()
        {
            Bicycle.Add(new BicyclePart { Id = 601, Name = "Seat Post" });
        }

        public void InstallHeadSet()
        {
            Bicycle.Add(new BicyclePart { Id = 602, Name = "Headset" });
        }

        public void InstallFork()
        {
            Bicycle.Add(new BicyclePart { Id = 603, Name = "Fork" });
        }

        public void InstallBottomBracket()
        {
            Bicycle.Add(new BicyclePart { Id = 604, Name = "Bottom Bracket" });
        }

        public void InstallCranks()
        {
            Bicycle.Add(new BicyclePart { Id = 605, Name = "Cranks" });
        }

        public void InstallPedals()
        {
            Bicycle.Add(new BicyclePart { Id = 606, Name = "Pedals" });
        }

        public void InstallCableGuide()
        {
            Bicycle.Add(new BicyclePart { Id = 607, Name = "Cable Guide" });
        }

        public void InstallDerailleur()
        {
            Bicycle.Add(new BicyclePart { Id = 608, Name = "Derailleur" });
        }

        public void InstallBrakes()
        {
            Bicycle.Add(new BicyclePart { Id = 609, Name = "Brakes" });
        }

        public void InstallChain()
        {
            Bicycle.Add(new BicyclePart { Id = 610, Name = "Chain" });
        }

        public void InstallCables()
        {
            Bicycle.Add(new BicyclePart { Id = 611, Name = "Cables" });
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