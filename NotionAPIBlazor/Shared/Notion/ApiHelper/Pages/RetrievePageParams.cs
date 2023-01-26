
using NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class RetrievePageParams : IRetrievePageParams
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
