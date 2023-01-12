using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    public class Properties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")] 
        public string Name { get;set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual PropertiesType Type { get; set; }
    }
}
