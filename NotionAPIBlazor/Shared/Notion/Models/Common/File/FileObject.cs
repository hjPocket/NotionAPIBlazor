using JsonSubTypes;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(FileConfig), "file")]
    [JsonSubtypes.KnownSubType(typeof(ExternalConfig), "external")]
    public abstract class FileObject : IIconProperty
    {
        [JsonProperty("type")]
        public virtual string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
