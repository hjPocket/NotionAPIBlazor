using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class Property
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
