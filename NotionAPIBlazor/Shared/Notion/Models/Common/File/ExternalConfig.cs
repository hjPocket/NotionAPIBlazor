using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class ExternalConfig : FileObject
    {
        public override string Type => "external";

        [JsonProperty("external")]
        public ExternalConfigValue External { get; set; }

        public class ExternalConfigValue
        {
            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}
