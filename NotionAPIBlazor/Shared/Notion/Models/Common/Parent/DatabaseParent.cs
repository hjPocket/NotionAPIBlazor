using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public class DatabaseParent : IPageParent
    {
        [JsonProperty("database_id")]
        public string DatabaseID { get; set; }

        public ParentType Type { get; set; }
    }
}
