using NotionAPIBlazor.Shared.Notion.Api;

namespace NotionAPIBlazor.Server.Service
{
    public class PageService
    {
        private readonly RestApi restAPI;
        public PageService(NotionAPIService notionAPIService)
        {
            restAPI = notionAPIService.GetRestApi();
        }
    }
}
