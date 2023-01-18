using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class Annotation
    {
        public bool bold { get; set; }

        public bool italic { get; set; }

        public bool strikethrough { get; set; }

        public bool underline { get; set; }

        public bool code { get; set; }

        public Color? color { get; set; }
    }
}
