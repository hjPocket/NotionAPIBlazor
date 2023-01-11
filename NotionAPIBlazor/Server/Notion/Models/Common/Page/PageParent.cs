using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Page
{
    public class PageParent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page_id")]
        public string PageID { get; set; }
    }
}
