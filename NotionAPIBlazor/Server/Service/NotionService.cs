using Microsoft.AspNetCore.DataProtection;
using NotionAPI.Client;
using NotionAPIBlazor.Server.Notion.Api;
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
        public async Task<object> QueryDatabase()
        {
            IDictionary<string, int> bodyData = new Dictionary<string, int>();
            bodyData["page_size"] = 100;

            return await restAPI.PostAsync<object>("/v1/databases/43d053f52a1545ca8c316373f851a28a/query", bodyData);

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
