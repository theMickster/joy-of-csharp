using System;
using GangOfFour.Core.Entities.ApplicationReports;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Flyweight
{
    public abstract class Report : IReport
    {
        public string ReportName { get; set; }

        public ReportHeader ReportHeader { get; private set; }

        public ReportFooter ReportFooter { get; private set; }

        protected string ReportBody;

        protected Report()
        {
            SetReportBody();
        }

        public void SetReportHeader(ReportHeader reportHeader)
        {
            ReportHeader = reportHeader;
        }

        protected abstract void SetReportBody();
        
        public void SetReportFooter(ReportFooter reportFooter)
        {
            ReportFooter = reportFooter;
        }

        public string PrintReport()
        {
            return ReportHeader.Print() + Environment.NewLine + ReportBody + Environment.NewLine + ReportFooter.Print();
        }
    }
}