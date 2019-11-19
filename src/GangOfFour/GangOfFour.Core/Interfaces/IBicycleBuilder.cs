namespace GangOfFour.Core.Interfaces
{
    public interface IBicycleBuilder
    {
        void InstallSeatPost();

        void InstallHeadSet();

        void InstallFork();

        void InstallBottomBracket();

        void InstallCranks();

        void InstallPedals();

        void InstallCableGuide();

        void InstallDerailleur();

        void InstallBrakes();

        void InstallChain();

        void InstallCables();

        void BicycleAssemblyIsComplete();

        void BicycleTestRideIsComplete();

        IBicycle DeliverBicycle();
    }
}