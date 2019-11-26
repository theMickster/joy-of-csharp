namespace GangOfFour.Core.Entities.ApplicationReports
{
    public class ReportFooter
    {
        public string ApplicationName { get; set; }

        public string Print()
        {
            return ApplicationName;
        }
    }
}