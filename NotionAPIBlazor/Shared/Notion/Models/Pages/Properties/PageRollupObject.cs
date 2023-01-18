using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageRollupObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("function")]
        public string Function { get; set; }

        [JsonProperty("array")]
        public string? Array { get; set; }

        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("incomplete")]
        public object? InComplete { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("unsupported")]
        public string? Unsupported { get; set; }
    }
}
