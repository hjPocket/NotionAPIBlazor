using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.File
{
    public class ExternalConfig : FileObject
    {
        public override FileObjectValue Type => FileObjectValue.External;

        [JsonProperty("external")]
        public ExternalConfigValue External { get; set; }
    }

    public class ExternalConfigValue
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
