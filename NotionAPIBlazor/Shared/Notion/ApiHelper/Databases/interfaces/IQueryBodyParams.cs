using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Filter;
using NotionAPIBlazor.Shared.Notion.Models.Sort;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases.interfaces
{
    public interface IQueryBodyParams
    {
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("start_cursor")]
        public string StartCursor { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("filter_properties")]
        public string FilterProperties { get; set; }
    }
}
