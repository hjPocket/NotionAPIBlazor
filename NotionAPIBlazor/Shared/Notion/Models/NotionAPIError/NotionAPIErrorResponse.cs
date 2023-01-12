using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.NotionAPIError
{
    public class NotionAPIErrorResponse
    {
        [JsonProperty("code")]
        public NotionAPIErrorCode ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
