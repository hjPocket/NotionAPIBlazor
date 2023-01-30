
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Search;
using NotionAPIBlazor.Shared.Notion.Models.Filter;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using NotionAPIBlazor.Shared.Notion.Models.Sort;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Extra
{
    public class SearchBodyParams
    {
        [JsonProperty("query")]
        public string? Query { get; set; }

        [JsonProperty("sort")]
        public Sort? Sorts { get; set; }

        [JsonProperty("filter")]
        public Filter? Filters { get; set; }

        [JsonProperty("start_cursor")]
        public string? StartCursor { get; set; }

        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
    }

    public class SearchBodyType
    {
        public SearchBodyParams? Data { get; set; }

        public PaginatedSearch ReturnData { get; set; }
    }
}
