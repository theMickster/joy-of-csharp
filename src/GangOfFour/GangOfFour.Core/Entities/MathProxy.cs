using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    /// <summary>
    /// The 'Proxy' class/object to be used in the proxy design pattern.
    /// </summary>
    public class MathProxy : IMath
    {
        private readonly Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}