namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The "Component' interface in the decorator design pattern.
    /// </summary>
    public interface IDessert
    {
        string BatterFlavor { get; set; }

        bool HasFrosting { get; set; }

        string FrostingFlavor { get; set; }

        decimal UnitCost { get; set; }

        decimal Price { get; }

        void UpdatePrice(decimal newPrice);

        string GetDetails();
    }
}