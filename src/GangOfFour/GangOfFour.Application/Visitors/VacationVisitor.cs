using GangOfFour.Core.Entities.Business;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Visitors
{
    public class VacationVisitor : IVisitor
    {
        private readonly int _additionalVacationDays;

        public VacationVisitor(int additionalVacationDays)
        {
            _additionalVacationDays = additionalVacationDays;
        }

        public void Visit(IPerson element)
        {
            if (element is Employee person) 
                person.VacationDays += _additionalVacationDays;
        }
    }
}