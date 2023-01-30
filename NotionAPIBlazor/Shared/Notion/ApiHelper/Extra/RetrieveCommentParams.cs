
using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Comments;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Extra
{
    public class RetrieveCommentParams : IQueryParams
    {
        public string BlockID { get; set; }

        public string? StartCursor { get; set; } = null;

        public int? PageSize { get; set; } = null;
    }

    public class RetrieveCommentType
    {
        public RetrieveCommentParams Data { get; set; }

        public PaginatedComment<Comment> RetrunData { get; set; }
    }
}
