using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class TextConfig : Property
    {
        public override PropertyType Type => PropertyType.RichText;

        [JsonProperty("rich_text")]
        public List<RichText> RichText { get; set; }
    }
}
