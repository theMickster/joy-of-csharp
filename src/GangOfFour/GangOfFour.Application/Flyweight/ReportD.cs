namespace GangOfFour.Application.Flyweight
{
    public class ReportD : Report
    {
        protected override void SetReportBody()
        {
            // In a real application, this data would be populated by a database.
            ReportBody = "Report body for Report D.";
        }
    }
}