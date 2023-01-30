using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Shared.Notion.Models.Extra.Search
{
    public class PaginatedSearch
    {
        [JsonProperty("page_or_database")]
        public object PageorDatabase { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        [JsonProperty("object")]
        public string? Object { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("page_results")]
        public List<Page>? Pages { get; set; }

        [JsonProperty("database_results")]
        public List<Database>? Databases { get; set; }
    }
}
