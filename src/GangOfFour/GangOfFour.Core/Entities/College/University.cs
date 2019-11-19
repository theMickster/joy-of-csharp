using System.Data.Common;

namespace GangOfFour.Core.Entities.College
{
    public class University
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public int YearFounded { get; set; }

        public int CurrentEnrollment { get; set; }
    }
}