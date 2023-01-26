
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces
{
    public interface IUpdatePageParams
    {
        [JsonProperty("properties")]
        public IDictionary<string, PageProperty> Properties { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("icon")]
        public IconProperty Icon { get; set; }

        [JsonProperty("cover")]
        public IconProperty Cover { get; set; }
    }
}
