namespace GangOfFour.Core.Entities.ApplicationReports
{
    public class ReportHeader
    {
        public string CompanyName { get; set; }
        
        public string Address1 { get; set; }

        public string Print()
        {
            return CompanyName + "  " + Address1;
        }
    }
}