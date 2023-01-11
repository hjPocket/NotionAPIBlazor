using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.Page
{
    public class WorkSpaceParent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workspace")]
        public string WorkSpace { get; set; }
    }
}
