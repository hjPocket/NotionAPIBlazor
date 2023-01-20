using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases
{
    public class Database : ICommonStruct
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

        [JsonProperty("title")]
        public List<RichText> Title { get; set; }

        [JsonProperty("description")]
        public List<RichText> Description { get; set; }

        [JsonProperty("icon")]
        public IconProperty Icon { get; set; }

        [JsonProperty("cover")]
        public FileObject Cover { get; set; }

        [JsonProperty("properties")]
        public Property Properties { get; set; }

        [JsonProperty("parent")]
        public ParentObject Parent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("is_inline")]
        public bool IsInline { get; set; }
    }
}
