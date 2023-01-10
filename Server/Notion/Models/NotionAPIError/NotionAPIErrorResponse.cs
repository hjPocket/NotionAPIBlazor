using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.NotionAPIError
{
    internal class NotionAPIErrorResponse
    {
        [JsonProperty("code")]
        public NotionAPIErrorCode ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
