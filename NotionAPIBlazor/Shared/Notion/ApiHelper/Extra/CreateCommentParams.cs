
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Comments;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Extra
{
    public class CreateCommentParams
    {
        [JsonProperty("parent")]
        public ParentObject Parent { get; set; }

        [JsonProperty("discussion_id")]
        public string DiscussionID { get;set; }

        [JsonProperty("rich_text")]
        public List<RichText> RichText { get; set; }
    }

    public class CreateCommentType
    {
        public CreateCommentParams Data { get; set; }

        public Comment ReturnData { get; set; }
    }
}
