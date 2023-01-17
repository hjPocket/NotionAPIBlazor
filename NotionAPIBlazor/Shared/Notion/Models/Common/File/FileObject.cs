using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    [JsonConverter(typeof(JsonSubtypes))]
    [JsonSubtypes.KnownSubType(typeof(FileConfig), "file")]
    [JsonSubtypes.KnownSubType(typeof(ExternalConfig), "external")]
    public class FileObject : IIconProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual string Type { get; set; }
    }
}
