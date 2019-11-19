namespace GangOfFour.Core.Interfaces
{
    public interface IBicycleShop
    {
        void UpdateBicycleBuilder(IBicycleBuilder builder);

        void ConstructBicycle();

        IBicycle GetBicycle();
    }
}