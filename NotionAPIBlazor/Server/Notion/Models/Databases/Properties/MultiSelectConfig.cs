using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Server.Notion.Models.Common;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class MultiSelectConfig : Property
    {
        public override PropertyType Type => PropertyType.MultiSelect;

        [JsonProperty("multi_select")]
        public MultiSelectType MultiSelect { get; set; }
    }

    public class MultiSelectType
    {
        [JsonProperty("options")]
        public List<MultiSelectOption> Options { get; set; }
    }

    public class MultiSelectOption
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color Color { get; set; }
    }
}
