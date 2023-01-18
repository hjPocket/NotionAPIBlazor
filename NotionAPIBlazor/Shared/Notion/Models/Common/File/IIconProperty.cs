using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(EmojiObject), "emoji")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "file")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "external")]
    public interface IIconProperty
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
