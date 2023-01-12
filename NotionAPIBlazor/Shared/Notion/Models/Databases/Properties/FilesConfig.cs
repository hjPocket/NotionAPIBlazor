using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class FilesConfig : Property
    {
        public override PropertyType Type => PropertyType.Files;

        [JsonProperty("files")]
        public string Files { get; set; }
    }
}
