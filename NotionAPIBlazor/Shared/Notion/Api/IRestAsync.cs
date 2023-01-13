using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Api
{
    public interface IRestAsync
    {
        Task<T> GetAsync<T>(
            string url, 
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings serializerSettings = null,
            CancellationToken cancellationToken = default);

        Task<T> PostAsync<T>(
            string url,
            object body,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings jsonSerializerSettings = null,
            CancellationToken cancellationToken = default);
    }
}
