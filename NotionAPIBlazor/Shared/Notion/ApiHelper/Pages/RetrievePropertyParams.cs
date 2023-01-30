using NotionAPIBlazor.Shared.Notion.ApiHelper.Interfaces;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class RetrievePropertyParams : IQueryParams
    {
        public int? PageSize { get; set; }
        public string? StartCursor { get; set; }
    }

    public class RetrievePropertyType
    {
        public string PageID { get; set; }

        public string PropertyID { get; set; }

        public RetrievePropertyParams queryParams { get; set; }

        public DynamicResponse ReturnData { get; set; }
    }
}
