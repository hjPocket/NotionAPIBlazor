using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using NotionAPI.Client;
using NotionAPI.Server.Service;
using NotionAPI.Shared;
using System.Net.Http.Headers;
using System.Text;

namespace NotionAPI.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotionController : ControllerBase
    {
        private readonly string _apiUri = "https://notion.api.com/v1";
        private readonly string secret = "secret_HEnVgiFxW3ORkDRJMFRB9n6KyjCrFqLPvvon5YkjQbL";

        private readonly NotionService notionService;

        public NotionController(NotionService notionService) {
            this.notionService = notionService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(NotionCode notionCode)
        {
            try
            {
                string key = $"6dbd114b-ee26-4d6a-b60c-2a7b0e6dc03c:secret_giJ6jWz1HMhcFxtCJ8aW8esIpuNJyY6CZPhw97ctFZW";

                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://api.notion.com/v1/oauth/token");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Add("mode", "no-cors");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", $"{key}");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await httpClient.PostAsJsonAsync<NotionCode>("https://api.notion.com/v1/oauth/token", notionCode);
                
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateDatabase(ResultJson json)
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
                { "Authorization", $"Bearer {secret}" }
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
                Console.WriteLine(body);
            }

            return Ok(body);
        }

        [HttpGet]
        public async Task<string> ListAllUsers()
        {
            //return await notionService.ListAllUsers();
            return "HIHIHI";
        }

        [HttpGet]
        public async Task<string> GetDatabase()
        {
            return await notionService.QueryDatabase();
        }
    }
}
