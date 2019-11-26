using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Flyweight
{
    public class ReportFactory
    {
        static readonly Dictionary<string, IReport> Reports = new Dictionary<string, IReport>();

        public static IReport GetReport(string key)
        {
            if (Reports.Keys.Contains(key))
            {
                return Reports[key];
            }

            switch (key)
            {
                case "A":
                {
                    IReport reportA = new ReportA{ReportName = "Awesome Report A"};
                    Reports.Add(key, reportA);
                    return reportA;
                }
                case "B":
                {
                    IReport reportB = new ReportB { ReportName = "Less Awesome Report B" };
                    Reports.Add(key, reportB);
                    return reportB;
                }
                case "C":
                {
                    IReport reportC = new ReportC { ReportName = "Kinda Awesome Report C" };
                    Reports.Add(key, reportC);
                    return reportC;
                }
                case "D":
                {
                    IReport reportD = new ReportD { ReportName = "Not Really Awesome Report D" };
                    Reports.Add(key, reportD);
                    return reportD;
                }
                default:
                    return null;
            }
        }
    }
}