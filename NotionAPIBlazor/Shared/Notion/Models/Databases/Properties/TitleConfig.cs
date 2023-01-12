using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class TitleConfig : Property
    {
        public override PropertyType Type => PropertyType.Title;

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
