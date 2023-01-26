using NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class RetrievePropertyParams : IRetrievePropertyParams
    {
        public int pageSize { get; set; }
        public string startCursor { get; set; }
    }

    public class RetrievePropertyType
    {
        public string PageID { get; set; }

        public string PropertyID { get; set; }

        public RetrievePropertyParams queryParams { get; set; }

        public DynamicResponse ReturnData { get; set; }
    }
}
