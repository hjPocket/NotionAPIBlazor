using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class EmojiObject : IIconProperty
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }
}
