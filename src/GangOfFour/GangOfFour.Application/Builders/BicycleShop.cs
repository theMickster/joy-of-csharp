using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Builders
{
    /// <summary>
    /// Director in the Builder pattern.
    /// </summary>
    public class BicycleShop : IBicycleShop
    {
        private IBicycleBuilder _bicycleBuilder;

        public BicycleShop()
        {
            
        }

        public BicycleShop(IBicycleBuilder bicycleBuilder)
        {
            _bicycleBuilder = bicycleBuilder;
        }

        public void UpdateBicycleBuilder(IBicycleBuilder builder)
        {
            _bicycleBuilder = builder;
        }

        public void ConstructBicycle()
        {
            _bicycleBuilder.InstallSeatPost();
            _bicycleBuilder.InstallHeadSet();
            _bicycleBuilder.InstallFork();
            _bicycleBuilder.InstallBottomBracket();
            _bicycleBuilder.InstallCranks();
            _bicycleBuilder.InstallPedals();
            _bicycleBuilder.InstallCableGuide();
            _bicycleBuilder.InstallDerailleur();
            _bicycleBuilder.InstallBrakes();
            _bicycleBuilder.InstallChain();
            _bicycleBuilder.InstallCables();
            _bicycleBuilder.BicycleAssemblyIsComplete();
            _bicycleBuilder.BicycleTestRideIsComplete();
        }

        public IBicycle GetBicycle()
        {
            return _bicycleBuilder.DeliverBicycle();
        }
    }
}