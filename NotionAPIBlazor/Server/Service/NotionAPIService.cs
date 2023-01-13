using Microsoft.Extensions.Options;
using NotionAPIBlazor.Shared.Notion.Api;

namespace NotionAPIBlazor.Server.Service
{
    public class NotionServiceOptions
    {
        public string SecretKey { get; set; }
        public string NotionVersion { get; set; }
        public string BaseUrl { get; set; }
    }
    public class NotionAPIService
    {
        private readonly RestApi restAPI;

        public NotionAPIService(IOptions<NotionServiceOptions> options)
        {
            this.restAPI = new RestApi(new NotionAPIBlazor.Shared.Notion.Api.Options()
            {
                SecretKey = options.Value.SecretKey,
                BaseUrl = options.Value.BaseUrl,
                NotionVersion = options.Value.NotionVersion
            });
        }

        public RestApi GetRestApi()
        {
            return restAPI;
        }
    }
}
