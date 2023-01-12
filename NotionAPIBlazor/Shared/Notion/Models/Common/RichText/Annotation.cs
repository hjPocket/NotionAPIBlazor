using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class Annotation
    {
        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("strikethrough")]
        public bool StrikeThrough { get; set; }

        [JsonProperty("underline")]
        public bool Underline { get; set; }

        [JsonProperty("code")]
        public bool Code { get; set; }

        [JsonProperty("color")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color? color { get; set; }
    }
}
