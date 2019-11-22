using GangOfFour.Core.Entities;

namespace GangOfFour.Core.Interfaces.SoftwareBugs
{
    public interface ISoftwareBugReportProcessor
    {
        void ProcessBugReport(SoftwareBugReport bugReport);
    }
}