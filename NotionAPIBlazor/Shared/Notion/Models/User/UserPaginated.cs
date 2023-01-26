
using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.User
{
    public class UserPaginated<T> : Pagination<T>
    {
        [JsonProperty("user")]
        public object User { get; set; }
    }
}
