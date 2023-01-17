using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public class WorkSpaceParent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workspace")]
        public string WorkSpace { get; set; }
    }
}
