
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class UpdateBodyParams
    {
        public List<RichText> Title { get; set; }
        public List<RichText> Description { get; set; }
        public IDictionary<string, Property> Properties { get; set; }
    }

    public class UpdateBodyType
    {
        public string DatabaseID { get; set; }

        public UpdateBodyParams Data { get; set; }

        public Database ReturnData { get; set; }
    }
}
