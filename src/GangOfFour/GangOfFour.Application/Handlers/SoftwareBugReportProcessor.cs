using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces.SoftwareBugs;
using System;
using System.Collections.Generic;

namespace GangOfFour.Application.Handlers
{
    public class SoftwareBugReportProcessor : ISoftwareBugReportProcessor
    {
        private readonly IList<IHandler<SoftwareBugReport>> _bugReportReceivers;

        public SoftwareBugReportProcessor(params IHandler<SoftwareBugReport>[] bugReportReceivers)
        {
            _bugReportReceivers = bugReportReceivers;
        }

        public void ProcessBugReport(SoftwareBugReport bugReport)
        {
            var handled = false;
            foreach (var receiver in _bugReportReceivers)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (!receiver.Handle(bugReport))
                {
                    continue;
                }
                else
                {
                    handled = true;
                    break;
                }
            }
        }
    }
}