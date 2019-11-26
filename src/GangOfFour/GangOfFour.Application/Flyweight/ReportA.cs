namespace GangOfFour.Application.Flyweight
{
    public class ReportA : Report
    {
        protected override void SetReportBody()
        {
            // In a real application, this data would be populated by a database.
            ReportBody = "Report body for Report A.";
        }
    }
}