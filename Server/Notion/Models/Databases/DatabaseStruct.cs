using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Common.Icon;
using NotionAPIBlazor.Server.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Server.Notion.Models.Databases
{
    public class DatabaseStruct
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("created_by")]
        public PartialUser CreatedBy { get; set; }

        [JsonProperty("last_edited_time")]
        public PartialUser LastEditedTime { get; set; }

        [JsonProperty("title")]
        public List<RichText> Title { get; set; }

        [JsonProperty("description")]
        public List<RichText> Description { get; set; }

        [JsonProperty("icon")]
        public IIcon Icon { get; set; }

        [JsonProperty("cover")]
        public FileObj Cover { get; set; }

        //[JsonProperty("properties")]
        //public Properties Properties { get; set; }

        //[JsonProperty("parent")]
        //public ParentInfo Parent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("is_inline")]
        public bool IsInline { get; set; }
    }
}
