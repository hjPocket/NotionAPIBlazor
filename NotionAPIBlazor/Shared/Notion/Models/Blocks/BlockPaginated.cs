
using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks
{
    public class BlockPaginated<T> : Pagination<T>
    {
        [JsonProperty("block")]
        public object Block { get; set; }
    }
}
