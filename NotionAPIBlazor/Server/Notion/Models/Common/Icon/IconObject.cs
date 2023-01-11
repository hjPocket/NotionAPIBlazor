using JsonSubTypes;
using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Common.File;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Icon
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(EmojiObject), "emoji")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "file")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "external")]
    public interface IconObject
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
