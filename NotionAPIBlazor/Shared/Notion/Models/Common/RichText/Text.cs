using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class Text
    {
        public string Content { get; set; }
        public Dictionary<string, string>? Link { get; set; }
    }
}
