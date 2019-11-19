using System.Linq;
using System.Xml.Linq;
using GangOfFour.Application.Services;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Converters
{
    public class XmlConverter : IXmlConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Universities");
            var xAttributes = UniversityDataService.GetUniversityData()
                .Select(m => new XElement("University",
                    new XAttribute("Name", m.Name),
                    new XAttribute("Location", m.Location),
                    new XAttribute("YearFounded", m.YearFounded),
                    new XAttribute("CurrentEnrollment", m.CurrentEnrollment)));

            xElement.Add(xAttributes);

            xDocument.Add(xElement);

            return xDocument;
        }
    }
}