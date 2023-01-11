using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Common.File
{
    public class FileConfig : FileObject
    {
        public override FileObjectValue Type => FileObjectValue.File;

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class FileValue
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expiry_time")]
        public string ExpiryTime { get; set; }
    }
}
