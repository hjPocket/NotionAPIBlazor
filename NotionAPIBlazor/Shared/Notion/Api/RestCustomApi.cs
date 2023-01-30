
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.NotionAPIError;
using System.Net.Http.Headers;
using System.Text;

namespace NotionAPIBlazor.Shared.Notion.Api
{
    public class RestCustomApi
    {
        readonly private Options options;
        public RestCustomApi(Options options)
        {
            this.options = options;
        }

        public async Task<HttpResponseMessage> SendAsync(
            string requestUri,
            HttpMethod httpMethod,
            IDictionary<string, string> queryParams = null,
            IDictionary<string, string> headers = null,
            Action<HttpRequestMessage> attachContent = null,
            CancellationToken cancellationToken = default)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(options.BaseUrl);

            requestUri = AddQueryString(requestUri, queryParams);

            using var httpRequest = new HttpRequestMessage(httpMethod, requestUri);
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", options.SecretKey);
            httpRequest.Headers.Add("Notion-Version", options.NotionVersion);

            if(headers != null)
            {
                AddHeaders(httpRequest, headers);
            }

            HttpResponseMessage response = await httpClient.SendAsync(httpRequest, cancellationToken);

            if(!response.IsSuccessStatusCode)
            {
                throw await BuildException(response);
            }

            return response;
        }

        public string AddQueryString(string requireUri, IDictionary<string, string> queryParams)
        {
            return queryParams == null ? requireUri : QueryHelpers.AddQueryString(requireUri, queryParams);
        }

        public void AddHeaders(HttpRequestMessage httpRequest, IDictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                httpRequest.Headers.Add(header.Key, header.Value);
            }
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
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}\n ::Error when parsing the notion api response");
                }
            }

            return new NotionApiException(response.StatusCode, errorResponse?.ErrorCode, errorResponse?.Message);
        }
    }
}
