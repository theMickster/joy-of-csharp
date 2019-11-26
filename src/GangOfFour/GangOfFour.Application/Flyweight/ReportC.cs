using GangOfFour.Core.Entities.ApplicationReports;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Flyweight
{
    public class ReportC : Report
    {
        protected override void SetReportBody()
        {
            // In a real application, this data would be populated by a database.
            ReportBody = "Report body for Report C.";
        }
    }
}