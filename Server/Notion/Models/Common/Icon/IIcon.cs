using JsonSubTypes;
using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Icon
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(EmojiObj), "emoji")]
    [JsonSubtypes.KnownSubType(typeof(FileObj), "file")]
    [JsonSubtypes.KnownSubType(typeof(FileObj), "external")]
    public interface IIcon
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
