using GangOfFour.Core.Entities.ApplicationReports;

namespace GangOfFour.Core.Interfaces
{
    public interface IReport
    {
        string ReportName { get; set; }

        void SetReportHeader(ReportHeader reportHeader);
        
        void SetReportFooter(ReportFooter reportFooter);

        string PrintReport();
    }
}