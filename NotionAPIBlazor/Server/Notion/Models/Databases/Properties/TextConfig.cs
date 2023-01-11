using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class TextConfig : Property
    {
        public override PropertyType Type => PropertyType.RichText;

        [JsonProperty("rich_text")]
        public List<RichText> RichText { get; set; }
    }
}
