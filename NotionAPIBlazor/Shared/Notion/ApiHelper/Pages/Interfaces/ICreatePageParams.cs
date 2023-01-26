
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Blocks;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces
{
    public interface ICreatePageParams
    {
        [JsonProperty("parent")]
        public ParentObject Parent { get; set; }

        [JsonProperty("properties")]
        public IDictionary<string, PageProperty> Properties { get; set; }

        [JsonProperty("children")]
        public List<Block>? Children { get; set; }

        [JsonProperty("icon")]
        public IconProperty Icon { get; set; }

        [JsonProperty("cover")]
        public IconProperty Cover { get; set; }
    }
}
