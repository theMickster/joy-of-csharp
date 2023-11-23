using GangOfFour.Core.Entities;

namespace GangOfFour.Core.Interfaces
{
    public interface IPerson
    {
        string Display();

        void Accept(IVisitor visitor);
    }
}