using System;
using System.Collections;
using System.Collections.Generic;
using GangOfFour.Application.Handlers;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Chain of Responsibility");

            var processor = GetSoftwareBugReportProcessor();

            var bugList = GetSoftwareBugList();

            foreach (var bug in bugList)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Processing bug =>   {bug.BugReport} Submitted by {bug.SubmittedBy}");
                processor.ProcessBugReport(bug);
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static IEnumerable<SoftwareBugReport> GetSoftwareBugList()
        {
            return new List<SoftwareBugReport>
            {
                new SoftwareBugReport{BugReport = "- Critical -", SubmittedBy = "user0000", Priority = Priority.Critical, SoftwareArea = SoftwareArea.Patient, Status = Status.NotHandled},
                new SoftwareBugReport{BugReport = "- High -", SubmittedBy = "user1001", Priority = Priority.High, SoftwareArea = SoftwareArea.Administration, Status = Status.NotHandled},
                new SoftwareBugReport{BugReport = "- Normal -", SubmittedBy = "user2002", Priority = Priority.Normal, SoftwareArea = SoftwareArea.Home, Status = Status.NotHandled},
                new SoftwareBugReport{BugReport = "- Low -", SubmittedBy = "user3003", Priority = Priority.Low, SoftwareArea = SoftwareArea.Home, Status = Status.NotHandled},
                new SoftwareBugReport{BugReport = "- Lowest -", SubmittedBy = "user4004", Priority = Priority.Lowest, SoftwareArea = SoftwareArea.Home, Status = Status.NotHandled}
            };
        }


        private static SoftwareBugReportProcessor GetSoftwareBugReportProcessor()
        {
            var handlerChain = new CriticalSoftwareBugHandler();

            handlerChain
                .SetNext(new HighSoftwareBugHandler())
                .SetNext(new NormalSoftwareBugHandler())
                .SetNext(new LowSoftwareBugHandler())
                .SetNext(new LowestSoftwareBugHandler());

            return new SoftwareBugReportProcessor(handlerChain);   
        }
    }
}
