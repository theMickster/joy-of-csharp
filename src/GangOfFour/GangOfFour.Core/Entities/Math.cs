using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    /// <summary>
    /// The 'Real/Concrete Subject' class in the proxy design pattern.
    /// </summary>
    public class Math : IMath
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }
}