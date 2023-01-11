using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Server.Notion.Models.Common;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class StatusConfig : Property
    {
        public override PropertyType Type => PropertyType.Status;

        [JsonProperty("status")]
        public StatusType Status { get; set; }
    }

    public class StatusType
    {
        [JsonProperty("options")]
        public List<StatusOptions> Options { get; set; }

        [JsonProperty("groups")]
        public List<StatusGroups> Groups { get; set; }
    }

    public class StatusOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color Color { get; set; }
    }

    public class StatusGroups
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color Color { get; set; }

        [JsonProperty("option_ids")]
        public List<string> OptionIds { get; set; }
    }
}
