using GangOfFour.Core.Entities;

namespace GangOfFour.Core.Interfaces.SoftwareBugs
{
    public interface IHandler<T> where T : class
    {
        bool Handle(T request);

        IHandler<T> SetNext(IHandler<T> handler);
    }
}