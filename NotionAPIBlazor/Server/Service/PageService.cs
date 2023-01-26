using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Pages;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using System.Reflection.PortableExecutable;
using System.Threading;
using System;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Pages.PropertyItem;

namespace NotionAPIBlazor.Server.Service
{
    public class PageService
    {
        private readonly RestApi restAPI;
        private readonly Options options;
        public PageService(NotionAPIService notionAPIService)
        {
            restAPI = notionAPIService.GetRestApi();
            options = notionAPIService.GetOptions();
        }

        public async Task<Page> RetrievePage(string page_id, RetrievePageParams? queryParams)
        {
            Dictionary<string, string> FilterProperties = new();
            if (queryParams != null)
            {
                FilterProperties.Add("filter_properties", queryParams.FilterProperties);

            }
            return await restAPI.GetAsync<Page>($"/v1/pages/{page_id}", FilterProperties); 
        }

        public async Task<Page> CreatePage(CreatePageParams Body)
        {
            return await restAPI.PostAsync<Page>($"/v1/pages", Body);
        }

        public async Task<Page> UpdatePage(string page_id, UpdatePageParams Body)
        {
            return await restAPI.PatchAsync<Page>($"/v1/pages/{page_id}", Body);
        }

        public async Task<DynamicResponse> RetrievePagePropertyItem(string page_id, string property_id, RetrievePropertyParams queryParams)
        {
            //동적 응답을 위한 클래스 모델
            DynamicResponse returnValue = new();

            //HttpClient 세팅
            RestCustomApi ApiClient = new RestCustomApi(options);

            //쿼리 파라미터 세팅
            Dictionary<string, string> Params = new();
            if(queryParams != null)
            {
                Params.Add("page_size", queryParams.pageSize.ToString());
                Params.Add("start_cursor", queryParams.startCursor);
            }

            //API 보내기
            HttpResponseMessage response = await ApiClient.SendAsync(
                $"/v1/pages/{page_id}/properties/{property_id}", 
                HttpMethod.Get, 
                Params, 
                null, 
                null, 
                default);

            //API 응답 값 string으로 읽기
            string msg = await response.Content.ReadAsStringAsync();

            //JsonNode 사용해서 리턴타입 알아내기
            string Type = CheckType(msg);
            returnValue.Type = Type;

            //반환된 flag를 통해서 응답 값 세팅
            if (Type.Equals("P"))
            {
                returnValue.PaginatedItems = JsonConvert.DeserializeObject<Paginated<PropertyItem>>(msg);
            }
            else if(Type.Equals("I"))
            {
                returnValue.Items = JsonConvert.DeserializeObject<PropertyItem>(msg);
            }

            return returnValue;
        }

        public string CheckType(string str)
        {
            JsonNode jsonNode = JsonNode.Parse(str);

            if (jsonNode == null) return "E";

            string Object = (string) jsonNode["object"];

            if (Object != null && Object.Equals("list"))
            {
                return "P";
            }
            if (Object != null && Object.Equals("property_item"))
            {
                return "I";
            }

            return "E";
        }
    }
}
