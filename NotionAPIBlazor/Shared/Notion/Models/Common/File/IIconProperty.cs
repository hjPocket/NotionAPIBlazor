using JsonSubTypes;
using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(EmojiObject), "emoji")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "file")]
    [JsonSubtypes.KnownSubType(typeof(FileObject), "external")]
    public interface IIconProperty
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
