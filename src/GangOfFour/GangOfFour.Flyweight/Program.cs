using System;
using GangOfFour.Application.Flyweight;
using GangOfFour.Core.Entities.ApplicationReports;

namespace GangOfFour.Flyweight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Flyweight");
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            var header = new ReportHeader
                {CompanyName = "My Awesome Company", Address1 = "123456 Sunny Lane Aurora, CO 80018"};
            var footer = new ReportFooter {ApplicationName = "My Awesome Application"};

            var reportA01 = ReportFactory.GetReport("A");
            reportA01.SetReportHeader(header);
            reportA01.SetReportFooter(footer);

            var reportA02 = ReportFactory.GetReport("A");

            var reportA03 = ReportFactory.GetReport("A");

            var reportB01 = ReportFactory.GetReport("B");
            reportB01.SetReportHeader(header);
            reportB01.SetReportFooter(footer);

            var reportB02 = ReportFactory.GetReport("B");

            var reportB03 = ReportFactory.GetReport("B");


            Console.WriteLine(reportA01.PrintReport());
            Console.WriteLine(reportA02.PrintReport());
            Console.WriteLine(reportA03.PrintReport());

            Console.WriteLine(reportB01.PrintReport());
            Console.WriteLine(reportB02.PrintReport());
            Console.WriteLine(reportB03.PrintReport());

        }
    }
}
