using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Server.Service
{
    public class DatabaseService
    {
        private readonly RestApi restAPI;
        public DatabaseService(NotionAPIService notionAPIService) {
            restAPI = notionAPIService.GetRestApi();
        }

        public async Task<Pagination<Page>> QueryDatabase(string database_id, QueryBodyParams bodyParam)
        {
            return await restAPI.PostAsync<Pagination<Page>>($"/v1/databases/{database_id}/query", bodyParam);
        }

        public async Task<Database> CreateDatabase(CreateBodyParams bodyParam)
        {
            return await restAPI.PostAsync<Database>($"/v1/databases/", bodyParam);
        }

        public async Task<Database> UpdateDatabase(string database_id, UpdateBodyParams bodyParam = null)
        {
            return await restAPI.PatchAsync<Database>($"/v1/databases/{database_id}", bodyParam);
        }

        public async Task<Database> RetrieveDatabase(string database_id)
        {
            return await restAPI.GetAsync<Database>($"/v1/databases/{database_id}");
        }
    }
}
