using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Users;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Server.Service
{
    public class UserService
    {
        private readonly RestApi restAPI;
        public UserService(NotionAPIService notionAPIService)
        {
            restAPI = notionAPIService.GetRestApi();
        }

        public async Task<PartialUser> RetrieveUser(string UserID)
        {
            return await restAPI.GetAsync<PartialUser>($"/v1/users/{UserID}");
        }

        public async Task<UserPaginated<PartialUser>> ListAllUsers(ListAllUsersParams? queryParams = null)
        {
            Dictionary<string, string> Params = new();

            if(queryParams != null)
            {
                Params.Add("start_cursor", queryParams.StartCursor);
                Params.Add("page_size", queryParams.PageSize.ToString());
            }

            return await restAPI.GetAsync<UserPaginated<PartialUser>>("/v1/users", Params);
        }

        public async Task<PartialUser> RetrieveBotUser()
        {
            return await restAPI.GetAsync<PartialUser>("/v1/users/me");
        }
    }
}
