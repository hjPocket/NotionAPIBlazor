using Microsoft.AspNetCore.DataProtection;
using NotionAPIBlazor.Server.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using System.Net.Http.Headers;

namespace NotionAPI.Server.Service
{
    public class NotionService
    {
        private readonly RestApi restAPI;
        public NotionService(NotionAPIService notionAPIService) {
            restAPI = notionAPIService.GetRestApi();
        }

        //Page
        public async Task CreatePage()
        {
            
        }

        //Database
        public async Task<object> QueryDatabase(string database_id, QueryBodyParams bodyParam)
        {
            return await restAPI.PostAsync<object>($"/v1/databases/{database_id}/query", bodyParam);
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
