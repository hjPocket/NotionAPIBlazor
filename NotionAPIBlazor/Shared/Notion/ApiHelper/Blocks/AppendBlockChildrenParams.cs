
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class AppendBlockChildrenParams
    {
        [JsonProperty("children")]
        public List<BlockObject> Children { get; set; }
    }

    public class AppendBlockChildrenType
    {
        public string BlockID { get; set; }

        public AppendBlockChildrenParams Data { get; set; }

        public BlockPaginated<Block> ReturnData { get; set; }
    }
}
