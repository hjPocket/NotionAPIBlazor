
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class RetrievePageParams
    {
        public string FilterProperties { get; set; }
    }

    public class RetrievePageType
    {
        public RetrievePageParams Params { get; set; }

        public string PageID { get; set; }

        public Page ReturnData { get; set; }
    }
}
