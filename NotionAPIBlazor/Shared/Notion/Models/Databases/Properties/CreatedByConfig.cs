using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class CreatedByConfig : Property
    {
        public override PropertyType Type => PropertyType.CreatedBy;

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }
}
