using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public class PageParent : IPageParent, IDatabaseParent
    {
        public ParentType Type { get; set; }

        [JsonProperty("page_id")]
        public string PageID { get; set; }
    }
}
