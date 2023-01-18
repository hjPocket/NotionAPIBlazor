using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageFormulaObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("boolean")]
        public bool Bool { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }
    }
}
