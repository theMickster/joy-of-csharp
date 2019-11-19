using System.Xml.Linq;

namespace GangOfFour.Core.Interfaces
{
    public interface IXmlConverter
    {
        XDocument GetXml();
    }
}