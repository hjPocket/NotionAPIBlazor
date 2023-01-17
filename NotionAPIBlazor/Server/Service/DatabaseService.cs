using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Server.Service
{
    public class DatabaseService
    {
        private readonly RestApi restAPI;
        public DatabaseService(NotionAPIService notionAPIService) {
            restAPI = notionAPIService.GetRestApi();
        }

        //Page
        public async Task CreatePage()
        {
            
        }

        //Database
        public async Task<Pagination<PageStruct>> QueryDatabase(string database_id, QueryBodyParams? bodyParam = null)
        {
            return await restAPI.PostAsync<Pagination<PageStruct>>($"/v1/databases/{database_id}/query", bodyParam);
        }

        public async Task CreateDatabase()
        { 
        }

        //Blocks


        //Users
        public async Task ListAllUsers()
        {
        }
    }
}
