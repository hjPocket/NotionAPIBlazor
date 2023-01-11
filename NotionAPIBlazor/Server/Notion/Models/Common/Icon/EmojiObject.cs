using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Icon
{
    public class EmojiObject
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }   //emoji character
    }
}
