
using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Extra.Comments
{
    public class PaginatedComment<T> : Pagination<T>
    {
        [JsonProperty("comment")]
        public object Comment { get; set; }
    }
}
