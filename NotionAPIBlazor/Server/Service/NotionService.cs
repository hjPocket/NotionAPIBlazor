using Microsoft.AspNetCore.DataProtection;
using NotionAPI.Client;
using System.Net.Http.Headers;

namespace NotionAPI.Server.Service
{
    public class NotionService
    {
        private readonly string key;
        private readonly string _apiUri = "https://api.notion.com/v1";
        public NotionService(NotionAPIService notionAPIService) {
            key = notionAPIService.GetSecret();   
        }

        //Page


        public async Task<string> CreatePage()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_apiUri}/pages"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Notion-Version", "2022-06-28" },
                    { "Authorization", $"Bearer {key}" }
                },
                Content = new StringContent("{\"parent\":\"string\",\"properties\":\"string\",\"children\":[\"string\"],\"icon\":\"string\",\"cover\":\"string\"}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }

        //Database
        public async Task<string> QueryDatabase()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_apiUri}/databases/43d053f52a1545ca8c316373f851a28a/query"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Notion-Version", "2022-06-28" },
                    { "Authorization", $"Bearer {key}" }
                },
                Content = new StringContent("{\"page_size\":100}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            string? body = null;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            return body;
        }
        public async Task<string> CreateDatabase()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_apiUri}/databases"),
                Headers =
                {
                    { "accept", "application/json" },
                        { "Notion-Version", "2022-06-28" },
                    { "Authorization", $"Bearer {key}" }
                },
                Content = new StringContent("{\"parent\":\"string\",\"properties\":\"string\"}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            string? body = null;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            return body;
        }

        //list all users
        public async Task<string> ListAllUsers()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_apiUri}/users"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Notion-Version", "2022-06-28" },
                    { "Authorization", $"Bearer {key}" }
                }
            };

            string? body = null;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            return body;
        }
    }
}
