using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Decorators
{
    /// <summary>
    /// The 'Concrete Decorator' class in the decorator design pattern.
    /// </summary>
    public class DayOldDessertDecorator : DessertDecorator
    {
        public int DiscountPercentage { get; set; }

        public string Offer { get; set; }

        public DayOldDessertDecorator(IDessert dessert) : base(dessert)
        {

        }

        public void ApplyDiscount() 
        {
            if (DiscountPercentage <= 0)
            {
                return;
            }
            var basePrice = Dessert.Price;
            var percentage = 100 - DiscountPercentage;
            Dessert.UpdatePrice( Math.Round((basePrice * percentage) / 100, 2));
        }
    }
}