using System;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Core.Entities
{
    public class SoftwareBugReport
    {
        public string SubmittedBy { get; set; }

        public SoftwareArea SoftwareArea { get; set; } = SoftwareArea.Home;

        public string BugReport { get; set; }

        public Priority Priority { get; set; } = Priority.Lowest;

        public DateTime SubmittedDate { get; set; } = DateTime.Now;

        public Status Status { get; set; } = Status.NotHandled;
    }
}