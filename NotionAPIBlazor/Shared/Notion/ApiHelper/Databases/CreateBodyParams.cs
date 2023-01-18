using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class CreateBodyParams
    {
        public ParentObject Parent { get; set; }
        public List<RichText> Title { get; set; }
    }

    public class CreateBodyType
    {
        [JsonProperty("Data")]
        public CreateBodyParams Data { get; set; }

        [JsonProperty("ReturnData")]
        public DatabaseStruct? ReturnData { get; set; }
    }
}
