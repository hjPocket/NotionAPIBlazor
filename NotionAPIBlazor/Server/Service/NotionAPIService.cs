using Microsoft.Extensions.Options;

namespace NotionAPI.Server.Service
{
    public class NotionServiceOptions
    {
        public string? SecretKey { get; set; }
    }
    public class NotionAPIService
    {
        private readonly string SecretKey;
        public NotionAPIService(IOptions<NotionServiceOptions> options)
        {
            this.SecretKey = options.Value.SecretKey;
        }

        public string GetSecret()
        {
            return this.SecretKey;
        }
    }
}
