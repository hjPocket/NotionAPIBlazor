using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class LastEditedTimeConfig : Property
    {
        public override PropertyType Type => PropertyType.LastEditedTime;

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }
    }
}
