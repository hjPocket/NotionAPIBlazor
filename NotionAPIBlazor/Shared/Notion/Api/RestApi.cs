using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NotionAPIBlazor.Shared.Notion.Models.NotionAPIError;

namespace NotionAPIBlazor.Shared.Notion.Api
{
    public class RestApi : IRestAsync
    {
        private readonly Options _options;
        private HttpClient _httpClient;
        protected readonly JsonSerializerSettings DefaultSerializerSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
        };

        public RestApi(Options options)
        {
            _options = MergeOptions(options);
        }

        public static Options MergeOptions(Options options)
        {
            return new Options
            {
                BaseUrl = options.BaseUrl,
                NotionVersion = options.NotionVersion,
                SecretKey = options.SecretKey,
            };
        }

        public async Task<T> GetAsync<T>(
            string url, 
            IDictionary<string, string> queryParams = null, 
            IDictionary<string, string> headers = null, 
            JsonSerializerSettings jsonSerializerSettings = null, 
            CancellationToken cancellationToken = default)
        {
            var response = await SendAsync(url, HttpMethod.Get, queryParams, headers, null, cancellationToken);
            return await response.ParseStreamAsync<T>(jsonSerializerSettings);
        }

        public async Task<T> PostAsync<T>(
            string url,
            object body = null,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings jsonSerializerSettings = null,
            CancellationToken cancellationToken = default)
        {
            void AttatchContent(HttpRequestMessage httpRequest)
            {
                if (body == null) return;

                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(body, DefaultSerializerSettings), Encoding.UTF8, "application/json");
            }

            var response = await SendAsync(url, HttpMethod.Post, queryParams, headers, AttatchContent, cancellationToken);
            return await response.ParseStreamAsync<T>(jsonSerializerSettings);
        }

        public async Task<T> PatchAsync<T>(
            string url,
            object body,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings jsonSerializerSettings = null,
            CancellationToken cancellationToken = default)
        {
            void AttatchContent(HttpRequestMessage httpRequest)
            {
                if (body == null) return;
                
                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(body, DefaultSerializerSettings), Encoding.UTF8, "application/json");
            }

            var response = await SendAsync(url, new HttpMethod("PATCH"), queryParams, headers, AttatchContent, cancellationToken);

            return await response.ParseStreamAsync<T>(jsonSerializerSettings);
        }

        public async Task<T> DeleteAsync<T>(
            string url,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings jsonSerializerSettings = null,
            CancellationToken cancellationToken = default)
        {
            var response = await SendAsync(url, HttpMethod.Delete, queryParams, headers, cancellationToken: cancellationToken);

            return await response.ParseStreamAsync<T>(null);
        }

        private async Task<HttpResponseMessage> SendAsync(
            string requestUri,
            HttpMethod httpMethod,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            Action<HttpRequestMessage> attachContent = null,
            CancellationToken cancellationToken = default)
        {
            EnsureHttpClient();

            requestUri = AddQueryString(requestUri, queryParams);

            using var httpRequest = new HttpRequestMessage(httpMethod, requestUri);
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.SecretKey);
            httpRequest.Headers.Add("Notion-Version", _options.NotionVersion);

            if(headers != null)
            {
                AddHeaders(httpRequest, headers);
            }

            attachContent?.Invoke(httpRequest);

            var response = await _httpClient.SendAsync(httpRequest, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw await BuildException(response);
            }

            return response;
        }

        private void AddHeaders(HttpRequestMessage httpRequest, IDictionary<string, string> headers)
        {
            foreach(var header in headers)
            {
                httpRequest.Headers.Add(header.Key, header.Value);
            }
        }
        private string AddQueryString(string requireUri, IDictionary<string, string> queryParams)
        {
            return queryParams == null ? requireUri : QueryHelpers.AddQueryString(requireUri, queryParams);
        }
        private void EnsureHttpClient()
        {
            if(_httpClient != null) return;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_options.BaseUrl);
        }

        private async Task<Exception> BuildException(HttpResponseMessage response)
        {
            var errorBody = await response.Content.ReadAsStringAsync();

            NotionAPIErrorResponse errorResponse = null;

            if (!string.IsNullOrWhiteSpace(errorBody))
            {
                try
                {
                    errorResponse = JsonConvert.DeserializeObject<NotionAPIErrorResponse>(errorBody);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex}\n ::Error when parsing the notion api response");
                }
            }

            return new NotionApiException(response.StatusCode, errorResponse?.ErrorCode, errorResponse?.Message);
        }
    }
}
