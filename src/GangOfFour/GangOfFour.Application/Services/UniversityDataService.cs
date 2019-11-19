using GangOfFour.Core.Entities.College;
using System.Collections.Generic;

namespace GangOfFour.Application.Services
{
    public static class UniversityDataService
    {
        public static List<University> GetUniversityData()
        {
            return new List<University>
            {
                new University{Name = "University of Alabama", Location = "Tuscaloosa, AL", YearFounded = 1831, CurrentEnrollment = 38103 }
                ,new University{Name = "University of Arkansas", Location = "Fayetteville, AR", YearFounded = 1871, CurrentEnrollment = 27559 }
                ,new University{Name = "Auburn University", Location = "Auburn, AL", YearFounded = 1856, CurrentEnrollment = 30460 }
                ,new University{Name = "University of Florida", Location = "Gainesville, FL", YearFounded = 1853, CurrentEnrollment = 56079 }
                ,new University{Name = "University of Georgia", Location = "Athens, GA", YearFounded = 1785, CurrentEnrollment = 38652 }
                ,new University{Name = "University of Kentucky", Location = "Lexington, KY", YearFounded = 1865, CurrentEnrollment = 30277 }
                ,new University{Name = "Louisiana State University", Location = "Baton Rouge, LA", YearFounded = 1860, CurrentEnrollment = 30634 }
                ,new University{Name = "University of Mississippi", Location = "Oxford, MS", YearFounded = 1848, CurrentEnrollment = 19786 }
                ,new University{Name = "Mississippi State University", Location = "Starkville, MS", YearFounded = 1878, CurrentEnrollment = 22226 }
                ,new University{Name = "University of Missouri", Location = "Columbia, MO", YearFounded = 1839, CurrentEnrollment = 30046 }
                ,new University{Name = "University of South Carolina", Location = "Columbia, SC", YearFounded = 1801, CurrentEnrollment = 34795 }
                ,new University{Name = "University of Tennessee", Location = "Knoxville, TN", YearFounded = 1794, CurrentEnrollment = 29460 }
                ,new University{Name = "Texas A&M University", Location = "College Station, TX", YearFounded = 1876, CurrentEnrollment = 69376 }
                ,new University{Name = "Vanderbilt University", Location = "Nashville, TN", YearFounded = 1873, CurrentEnrollment = 12824 }
            };
        }
    }
}