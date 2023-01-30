using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Extra;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Comments;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Search;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using System.Text;
using System.Text.Json.Nodes;

namespace NotionAPIBlazor.Server.Service
{
    public class ExtraService
    {
        private readonly RestApi restAPI;
        private readonly Options options;

        protected readonly JsonSerializerSettings DefaultSerializerSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
        };

        public ExtraService(NotionAPIService notionAPIService) 
        {
            restAPI = notionAPIService.GetRestApi();
            options = notionAPIService.GetOptions();
        }

        public async Task<PaginatedSearch> Search(SearchBodyParams? Body = null)
        {
            RestCustomApi ApiClient = new RestCustomApi(options);

            void AttatchContent(HttpRequestMessage httpRequest)
            {
                if (Body == null) return;

                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(Body, DefaultSerializerSettings), Encoding.UTF8, "application/json");
            }

            HttpResponseMessage response = await ApiClient.SendAsync(
                $"/v1/search",
                HttpMethod.Post,
                null, null, AttatchContent, default);

            string msg = await response.Content.ReadAsStringAsync();

            var paginatedSearch = SetObject(msg);

            return paginatedSearch;
        }

        public async Task<PaginatedComment<Comment>> RetrieveComment(RetrieveCommentParams queryParams)
        {
            Dictionary<string, string> Params = new();
            if(queryParams != null)
            {
                Params.Add("block_id", queryParams.BlockID);
                Params.Add("start_cursor", queryParams?.StartCursor);
                Params.Add("page_size", queryParams?.PageSize.ToString());
            }

            return await restAPI.GetAsync<PaginatedComment<Comment>>($"/v1/comments", Params);
        }

        public async Task<Comment> CreateComment(CreateCommentParams? Data = null)
        {
            return await restAPI.PostAsync<Comment>($"/v1/comments", Data);
        }

        public PaginatedSearch SetObject(string msg)
        {
            PaginatedSearch Search = new();
            JsonNode jsonNode = JsonNode.Parse(msg);

            if (jsonNode == null) return Search;

            Search.PageorDatabase = jsonNode!["page_or_database"];
            Search.Object = jsonNode!["object"]?.ToJsonString();
            Search.Type = jsonNode!["type"]?.ToJsonString();
            Search.HasMore = (bool) jsonNode!["has_more"];
            Search.NextCursor = jsonNode!["next_cursor"]?.ToJsonString();

            JsonNode Results = jsonNode!["results"];

            if(Results != null)
            {
                JsonArray results = Results.AsArray();

                List<Page> Pages = new();
                List<Database> Databases = new();

                foreach (var item in results)
                {
                    string Object = item!["object"]?.ToString();

                    if (Object.Equals("page"))
                    {
                        Console.Write("=======??");
                        Console.WriteLine(item.ToJsonString());
                        Page page = JsonConvert.DeserializeObject<Page>(item.ToJsonString());

                        if(page != null)
                        {
                            Pages.Add(page);
                        }
                    }
                    else if (Object.Equals("database"))
                    {
                        Database database = JsonConvert.DeserializeObject<Database>(item.ToJsonString());

                        if(database != null)
                        {
                            Databases.Add(database);
                        }
                    }
                }

                Search.Pages = Pages;
                Search.Databases = Databases;
            }

            return Search;
        }
    }
}
