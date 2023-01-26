using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.PropertyItem
{
    public class PropertyItem
    {
        [JsonProperty("object")]
        public string? Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("next_url")]
        public string? NextUrl { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        public List<RichText>? title { get; set; }

        public List<RichText>? rich_text { get; set; }

        public int? number { get; set; }

        public PageCommonObject? select { get; set; }

        public List<PageCommonObject>? multi_select { get; set; }

        public PageDateObject? date { get; set; }

        public PageFormulaObject? formula { get; set; }

        public PageRelationObject? relation { get; set; }

        public PageRollupObject? rollup { get; set; }

        public PartialUser people { get; set; }

        public FileObject? files { get; set; }

        public bool? checkbox { get; set; }

        public string? url { get; set; }
        public string? email { get; set; }
        public string? phone_number { get; set; }

        public string? created_time { get; set; }

        public PartialUser? created_by { get; set; }

        public string? last_edited_time { get; set; }

        public PartialUser? last_edited_by { get; set; }
    }
}
