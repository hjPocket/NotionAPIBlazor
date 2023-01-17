using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Filter;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using NotionAPIBlazor.Shared.Notion.Models.Sort;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class QueryBodyParams : IQueryBodyParams
    {
        public Filter Filter { get; set; }

        public Sort Sort { get; set; }

        public string StartCursor { get; set; }

        public int PageSize { get; set; }

        public string FilterProperties { get; set; }
    }

    public class QueryBodyType
    {
        [JsonProperty("Data")]
        public QueryBodyParams Data { get; set; }

        [JsonProperty("DatabaseID")]
        public string DatabaseID { get; set; }

        [JsonProperty("ReturnData")]
        public Pagination<PageStruct>? ReturnData { get; set; }
    }
}
