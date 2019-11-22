using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Decorators
{
    /// <summary>
    /// The 'Decorator' abstract class used in the decorator pattern.
    /// </summary>
    public abstract class DessertDecorator : IDessert
    {
        protected readonly IDessert Dessert;

        protected DessertDecorator(IDessert dessert)
        {
            Dessert = dessert;
        }

        public string BatterFlavor
        {
            get => Dessert.BatterFlavor;
            set => Dessert.BatterFlavor = value;
        }

        public bool HasFrosting
        {
            get => Dessert.HasFrosting;
            set => Dessert.HasFrosting = value;
        }

        public string FrostingFlavor
        {
            get => Dessert.FrostingFlavor;
            set => Dessert.FrostingFlavor = value;
        }
        
        public decimal UnitCost
        {
            get => Dessert.UnitCost;
            set => Dessert.UnitCost = value;
        }

        public decimal Price => Dessert.Price;

        public void UpdatePrice(decimal newPrice)
        {
            Dessert.UpdatePrice(newPrice);
        }
        public string GetDetails()
        {
            return Dessert.GetDetails();
        }
    }
}