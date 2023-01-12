using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Icon
{
    public class EmojiObject
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }   //emoji character
    }
}
