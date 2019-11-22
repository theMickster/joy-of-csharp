using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Desserts
{
    public class Cupcake : IDessert
    {
        public string BatterFlavor { get; set; }
        
        public bool HasFrosting { get; set; }
        
        public string FrostingFlavor { get; set; }
        
        public decimal UnitCost { get; set; }
        
        public decimal Price { get; private set; }

        public void UpdatePrice(decimal newPrice)
        {
            if(newPrice < UnitCost)
            { 
                throw  new ArgumentOutOfRangeException(nameof(newPrice), $"The new price of {newPrice} cannot be less than the unit cost.");
            }

            Price = newPrice;
        }

        public string GetDetails()
        {
            return $"Cupcake Details => Batter {BatterFlavor} Frosting {FrostingFlavor} Cost {UnitCost} Price {Price}";
        }
    }
}