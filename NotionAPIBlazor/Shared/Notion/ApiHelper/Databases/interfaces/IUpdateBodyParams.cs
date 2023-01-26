using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases.interfaces
{
    public interface IUpdateBodyParams
    {
        [JsonProperty("title")]
        public List<RichText> Title { get; set; }

        [JsonProperty("description")]
        public List<RichText> Description { get; set; }

        [JsonProperty("properties")]
        public IDictionary<string, Property> Properties { get; set; }
    }
}
