using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models
{
    public class Pagination<T>
    {
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        [JsonProperty("results")]
        public List<T>? Results { get; set; }

        [JsonProperty("object")]
        public string? Object { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
