using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageFormulaConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Formula;

        [JsonProperty("formula")]
        public Formula Formula { get; set; }
    }

    public class Formula
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
