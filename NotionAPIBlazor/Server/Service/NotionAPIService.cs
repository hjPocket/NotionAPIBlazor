using Microsoft.Extensions.Options;
using NotionAPIBlazor.Server.Notion.Api;

namespace NotionAPI.Server.Service
{
    public class NotionServiceOptions
    {
        public string? SecretKey { get; set; }
        public string? NotionVersion { get; set; }

        public string? BaseUrl { get; set; }
    }
    public class NotionAPIService
    {
        private readonly string BaseUrl;
        private readonly string SecretKey;
        private readonly string NotionVersion;

        public NotionAPIService(IOptions<NotionServiceOptions> options)
        {
            this.BaseUrl = options.Value.BaseUrl;
            this.SecretKey = options.Value.SecretKey;
            this.NotionVersion = options.Value.NotionVersion;
        }

        public RestApi GetRestApi()
        {
            var restAPI = new RestApi(new NotionAPIBlazor.Server.Notion.Api.Options() { SecretKey = this.SecretKey, BaseUrl= this.BaseUrl, NotionVersion = this.NotionVersion });
            return restAPI;
        }
    }
}
