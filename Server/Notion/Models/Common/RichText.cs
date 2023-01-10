using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Common;

namespace NotionAPIBlazor.Server.Notion.Models.RichText
{
    public class RichText
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("annotations")]
        public Annotation Annotaion { get; set; }
    }

    public class Text
    {
        public string Content { get; set; }
        public Dictionary<string, string> Link { get; set; }
    }

    public class Mention
    {
        public string Type { get; set; }
        public 
    }
}
