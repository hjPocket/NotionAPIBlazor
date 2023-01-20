
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases.interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Databases;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public class RetrieveBodyParams : IRetrieveBodyParams
    {
    }

    public class RetrieveBodyType
    {
        public string DatabaseID { get; set; }

        public Database? ReturnData { get; set; }
    }
}
