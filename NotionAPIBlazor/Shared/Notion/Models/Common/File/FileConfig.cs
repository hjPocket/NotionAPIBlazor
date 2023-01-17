using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class FileConfig : FileObject
    {
        public override string Type => "file";

        [JsonProperty("file")]
        public string File { get; set; }

        public class FileConfigValue
        {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("expiry_time")]
            public string ExpiryTime { get; set; }
        }
    }
}
