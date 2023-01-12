using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class URLConfig : Property
    {
        public override PropertyType Type => PropertyType.Url;

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
