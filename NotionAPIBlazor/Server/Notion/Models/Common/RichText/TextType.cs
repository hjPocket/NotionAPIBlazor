using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.RichText
{
    public class TextType : RichText
    {
        public override RichTextType Type => RichTextType.Text;

        [JsonProperty("text")]
        public Text Text { get; set; }
    }

    public class Text
    {
        public string Content { get; set; }
        public Dictionary<string, string> Link { get; set; }
    }
}
