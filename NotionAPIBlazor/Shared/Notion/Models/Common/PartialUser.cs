using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common
{
    public class PartialUser
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
