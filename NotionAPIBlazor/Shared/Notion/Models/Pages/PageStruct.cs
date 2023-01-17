using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages
{
    public class PageStruct : ICommonStruct
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("created_by")]
        public PartialUser CreatedBy { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("last_edited_by")]
        public PartialUser LastEditedBy { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("icon")]
        public IIconProperty Icon { get; set; }

        [JsonProperty("cover")]
        public FileObject Cover { get; set; }

        [JsonProperty("properties")]
        public Property Properties { get; set; }

        [JsonProperty("parent")]
        public IPageParent Parent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
