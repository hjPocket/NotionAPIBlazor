using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Filter;
using NotionAPIBlazor.Shared.Notion.Models.Sort;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class QueryBodyParams
    {
        public Filter? filter { get; set; }

        public Sort? sort { get; set; }

        public string? start_cursor { get; set; }

        public int? page_size { get; set; }

        public string filter_properties { get; set; }
    }
}
