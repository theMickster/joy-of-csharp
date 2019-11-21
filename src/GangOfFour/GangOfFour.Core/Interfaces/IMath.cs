namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The 'Subject' interface used by the proxy design pattern.
    /// </summary>
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}