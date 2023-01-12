using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class PeopleConfig : Property
    {
        public override PropertyType Type => PropertyType.People;

        [JsonProperty("people")]
        public string People { get; set; }
    }
}
