using Microsoft.Extensions.Options;
using NotionAPIBlazor.Shared.Notion.Api;
using System.Runtime.CompilerServices;
using Options = NotionAPIBlazor.Shared.Notion.Api.Options;

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
        private readonly Options options;

        public NotionAPIService(IOptions<NotionServiceOptions> options)
        {
            this.options = new Options()
            {
                SecretKey = options.Value.SecretKey,
                BaseUrl = options.Value.BaseUrl,
                NotionVersion = options.Value.NotionVersion
            };

            this.restAPI = new RestApi(this.options);
        }

        public RestApi GetRestApi()
        {
            return restAPI;
        }

        public Options GetOptions()
        {
            return options;
        }
    }
}
