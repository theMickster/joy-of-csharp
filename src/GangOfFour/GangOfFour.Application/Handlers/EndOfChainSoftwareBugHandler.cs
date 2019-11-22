using System;
using System.ComponentModel;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces.SoftwareBugs;

namespace GangOfFour.Application.Handlers
{
    public class EndOfChainSoftwareBugHandler : IHandler<SoftwareBugReport>
    {
        private EndOfChainSoftwareBugHandler()
        {
        }

        public static EndOfChainSoftwareBugHandler Instance { get; } = new EndOfChainSoftwareBugHandler();

        public bool Handle(SoftwareBugReport request)
        {
            request.Status = Status.Handled;
            return true;
        }

        public IHandler<SoftwareBugReport> SetNext(IHandler<SoftwareBugReport> handler)
        {
            throw new InvalidOperationException("The SetNext() method cannot be invoked on the end of chain handler.");
        }
    }
}