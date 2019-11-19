using System;
using GangOfFour.Application.Adapters;
using GangOfFour.Application.Converters;
using GangOfFour.Application.Services;

namespace GangOfFour.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Adapter");

            var xmlConverter = new XmlConverter();
            var jsonConverter = new JsonConverter(UniversityDataService.GetUniversityData());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("XML Data Representation");
            Console.WriteLine(xmlConverter.GetXml());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************************************************************");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("JSON Data Representation");
            Console.WriteLine(jsonConverter.ConvertToJson());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************************************************************");

            var adapter = new XmlToJsonAdapter(xmlConverter);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Converted JSON Data Representation");
            Console.WriteLine(adapter.ConvertXmlToJson());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************************************************************");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
