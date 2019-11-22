using System;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Application.Handlers
{
    public class CriticalSoftwareBugHandler : SoftwareBugHandler
    {
        public override bool Handle(SoftwareBugReport request)
        {
            if (request.Priority != Priority.Critical)
            {
                return base.Handle(request);
            }

            Console.WriteLine($"Bug handled by {nameof(CriticalSoftwareBugHandler)} handler.");
            Console.WriteLine($"++ Bug alert sent to team on-call via PagerDuty .");
            Console.WriteLine($"++ Bug alert sent to on-call developer Slack channel.");
            Console.WriteLine($"++ Bug alert sent to product owner Slack channel.");
            Console.WriteLine($"++ Bug added to Azure DevOps to top of product backlog.");
            Console.WriteLine($"++ Adding Priority Tag {request.Priority.ToString()}");
            request.Status = Status.Handled;
            return true;
        }
    }
}