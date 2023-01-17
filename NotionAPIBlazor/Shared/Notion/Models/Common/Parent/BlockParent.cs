using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public class BlockParent
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("block_id")]
        public string BlockID { get; set; }
    }
}
