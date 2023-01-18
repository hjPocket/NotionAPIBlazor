using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class RichText
    {
        public string type { get; set; }

        public string plain_text { get; set; }

        public string? href { get; set; }

        public Annotation annotations { get; set; }

        public Text? text { get; set; }

        public Mention? mention { get; set; }

        public Equation? equation { get; set; }
    }
}
