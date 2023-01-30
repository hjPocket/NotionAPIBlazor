
using NotionAPIBlazor.Shared.Notion.ApiHelper.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Users
{
    public class ListAllUsersParams : IQueryParams
    {
        public string? StartCursor { get; set; }

        public int? PageSize { get; set; }
    }

    public class ListAllUsersType
    {
        public ListAllUsersParams Data { get; set; }

        public UserPaginated<PartialUser> ReturnData { get; set; }
    }
}
