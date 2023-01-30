
using NotionAPIBlazor.Shared.Notion.Models.Databases;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class RetrieveBodyParams
    {
    }

    public class RetrieveBodyType
    {
        public string DatabaseID { get; set; }

        public Database? ReturnData { get; set; }
    }
}
