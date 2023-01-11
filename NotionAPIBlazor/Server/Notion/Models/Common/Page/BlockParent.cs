using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Page
{
    public class BlockParent
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("block_id")]
        public string BlockID { get; set; }
    }
}
