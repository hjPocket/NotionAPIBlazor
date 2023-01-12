using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Page
{
    public class DatabaseParent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("database_id")]
        public string DatabaseID { get; set; }
    }
}
