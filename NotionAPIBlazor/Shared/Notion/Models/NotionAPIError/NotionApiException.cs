using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace NotionAPIBlazor.Shared.Notion.Models.NotionAPIError
{
    [SuppressMessage("LangCodeNodeAPI", "MemberCanBePrivate.Global")]
    public class NotionApiException : Exception
    {
        public NotionApiException(HttpStatusCode statusCode, NotionAPIErrorCode? notionAPIErrorCode, string message) : this(statusCode, notionAPIErrorCode, message, null)
        {

        }

        private NotionApiException(HttpStatusCode statusCode, NotionAPIErrorCode? notionAPIErrorCode, string message, Exception innerException) : base(message, innerException)
        {
            NotionAPIErrorCode = notionAPIErrorCode;
            statusCode = statusCode;

            Data.Add("StatusCode", statusCode);
            Data.Add("NotionApiErrorCode", notionAPIErrorCode);
        }

        public NotionAPIErrorCode? NotionAPIErrorCode { get; }

        public HttpStatusCode StatusCode { get; }
    }
}
