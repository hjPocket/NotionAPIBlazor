using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Page
{
    public class DatabaseParent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("database_id")]
        public string DatabaseID { get; set; }
    }
}
