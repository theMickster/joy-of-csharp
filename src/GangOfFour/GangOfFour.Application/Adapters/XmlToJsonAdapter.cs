using System;
using System.Linq;
using GangOfFour.Application.Converters;
using GangOfFour.Core.Entities.College;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Adapters
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public string ConvertXmlToJson()
        {
            var universities = _xmlConverter.GetXml()
                .Element("Universities")
                ?.Elements("University")
                .Select(m => new University
                {
                    Name = m.Attribute("Name")?.Value,
                    Location = m.Attribute("Location")?.Value,
                    YearFounded = Convert.ToInt32(m.Attribute("YearFounded")?.Value),
                    CurrentEnrollment = Convert.ToInt32(m.Attribute("CurrentEnrollment")?.Value)
                });

            return new JsonConverter(universities).ConvertToJson();
        }
    }
}