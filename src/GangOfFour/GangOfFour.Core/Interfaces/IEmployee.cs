namespace GangOfFour.Core.Interfaces
{
    public interface IEmployee : IPerson
    {
        void UpdateEmployeePayRate(int payRate);
        
        IEmployee Clone();
    }
}