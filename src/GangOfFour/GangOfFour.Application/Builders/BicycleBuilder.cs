using GangOfFour.Core.Entities;

namespace GangOfFour.Application.Builders
{
    public abstract class BicycleBuilder
    {
        protected Bicycle Bicycle;

        protected BicycleBuilder()
        {
            Bicycle = new Bicycle();
        }

        public abstract void BicycleAssemblyIsComplete();

        public abstract void BicycleTestRideIsComplete();
    }
}