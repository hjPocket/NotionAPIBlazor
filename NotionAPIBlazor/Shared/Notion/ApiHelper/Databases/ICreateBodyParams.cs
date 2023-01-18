using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public interface ICreateBodyParams
    {
        //required
        [JsonProperty("parent")]
        public ParentObject Parent { get; set; }

        [JsonProperty("title")]
        public List<RichText> Title { get; set; }

        //required
        [JsonProperty("properties")]
        public IDictionary<string, Property> Properties { get; set; }
    }
}
