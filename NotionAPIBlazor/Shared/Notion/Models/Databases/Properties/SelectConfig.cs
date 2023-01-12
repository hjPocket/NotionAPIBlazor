using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Shared.Notion.Models.Common;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class SelectConfig : Property
    {
        [JsonProperty("select")]
        public SelectType Select { get; set; }
    }

    public class SelectType
    {
        [JsonProperty("options")]
        public List<SelectValue> Options { get; set; }
    }

    public class SelectValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color Color { get; set; }
    }
}
