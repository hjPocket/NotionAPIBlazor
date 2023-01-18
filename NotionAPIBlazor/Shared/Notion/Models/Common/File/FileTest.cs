using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class FileTest
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public File? File { get; set; }

        [JsonProperty("external")]
        public External? External { get; set; }
    }

    public class File
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expiry_time")]
        public string ExpiryTime { get; set; }
    }

    public class External
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
