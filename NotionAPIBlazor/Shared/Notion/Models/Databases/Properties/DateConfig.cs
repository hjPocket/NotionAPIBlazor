using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class DateConfig : Property
    {
        public override PropertyType Type => PropertyType.Date;

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}
