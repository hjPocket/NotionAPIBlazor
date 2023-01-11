using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Server.Notion.Models.Common;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class NumberConfig : Property
    {
        public override PropertyType Type => PropertyType.Number;

        [JsonProperty("number")]
        public NumberType Number { get; set; }
    }

    public class NumberType
    {
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FormatValue Format { get; set; }
    }
}
