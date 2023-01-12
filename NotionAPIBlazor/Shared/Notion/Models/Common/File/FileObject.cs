using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    [JsonConverter(typeof(JsonSubtypes))]
    [JsonSubtypes.KnownSubType(typeof(FileObject), FileObjectValue.File)]
    [JsonSubtypes.KnownSubType(typeof(ExternalConfig), FileObjectValue.External)]
    public class FileObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual FileObjectValue Type { get; set; }
    }
}
