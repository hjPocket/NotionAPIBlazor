
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Users
{
    public class RetrieveUserParams
    {

    }

    public class RetrieveUserType
    {
        public string UserID { get; set; }

        public PartialUser ReturnData { get; set; }
    }
}
