using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Filter;

namespace NotionAPIBlazor.Server.Notion.ApiHelper.Databases
{
    public class QueryBodyParams
    {
        public Filter filter { get; set; }
    }
}
