using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases.interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class CreateBodyParams : ICreateBodyParams
    {
        public ParentObject Parent { get; set; }
        public List<RichText> Title { get; set; }
        public IDictionary<string, Property> Properties { get; set; }
    }

    public class CreateBodyType
    {
        [JsonProperty("Data")]
        public CreateBodyParams Data { get; set; }

        [JsonProperty("ReturnData")]
        public Database? ReturnData { get; set; }
    }
}
