using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Databases
{
    public class PartialUser
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
