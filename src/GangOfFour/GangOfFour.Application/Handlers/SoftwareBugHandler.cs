using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces.SoftwareBugs;

namespace GangOfFour.Application.Handlers
{
    public abstract class SoftwareBugHandler : IHandler<SoftwareBugReport>
    {
        private IHandler<SoftwareBugReport> _nextHandler = EndOfChainSoftwareBugHandler.Instance;

        public virtual bool Handle(SoftwareBugReport request)
        {
            return this._nextHandler != null && this._nextHandler.Handle(request);
        }

        public IHandler<SoftwareBugReport> SetNext(IHandler<SoftwareBugReport> handler)
        {
            this._nextHandler = handler;

            return handler;
        }
    }
}