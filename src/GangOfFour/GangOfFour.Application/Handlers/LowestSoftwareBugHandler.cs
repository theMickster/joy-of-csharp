using System;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Application.Handlers
{
    public class LowestSoftwareBugHandler : SoftwareBugHandler
    {
        public override bool Handle(SoftwareBugReport request)
        {
            if (request.Priority != Priority.Lowest)
            {
                return base.Handle(request);
            }

            Console.WriteLine($"Bug handled by {nameof(LowestSoftwareBugHandler)} handler.");
            Console.WriteLine($"++ Bug added to Azure DevOps to bottom of product backlog.");
            Console.WriteLine($"++ Adding Priority Tag {request.Priority.ToString()}");
            request.Status = Status.Handled;
            return true;
        }
    }
}