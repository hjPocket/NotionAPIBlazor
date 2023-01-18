using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;

namespace NotionAPIBlazor.Shared.Notion.Models.Common
{
    public interface ICommonStruct
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
        public IconProperty Icon { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}
