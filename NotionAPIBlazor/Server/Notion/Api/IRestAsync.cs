using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Api
{
    public interface IRestAsync
    {
        Task<object> GetAsync<T>(
            string url, 
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings serializerSettings = null,
            CancellationToken cancellationToken = default);

        Task<object> PostAsync<T>(
            string url,
            object body,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings jsonSerializerSettings = null,
            CancellationToken cancellationToken = default);
    }
}
