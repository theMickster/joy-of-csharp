using GangOfFour.Core.Entities.College;
using GangOfFour.Core.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GangOfFour.Application.Converters
{
    public class JsonConverter : IJsonConverter
    {
        private readonly IEnumerable<University> _universities;

        public JsonConverter(IEnumerable<University> universities)
        {
            _universities = universities;
        }

        public string ConvertToJson()
        {
            return JsonConvert.SerializeObject(_universities, Formatting.Indented);

        }
    }
}