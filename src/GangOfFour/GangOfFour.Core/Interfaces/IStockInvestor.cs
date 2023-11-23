namespace GangOfFour.Core.Interfaces
{
    public interface IStockInvestor
    {
        IStock Stock { get; set; }

        string Name { get; set; }

        void Update(IStock stock);
    }
}