
using NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class UpdatePageParams : IUpdatePageParams
    {
        public IDictionary<string, PageProperty> Properties { get; set; }
        public bool Archived { get; set; }
        public IconProperty Icon { get; set; }
        public IconProperty Cover { get; set; }
    }

    public class UpdatePageType
    {
        public string PageID { get; set; }
        public UpdatePageParams Data { get; set; }
        public Page ReturnValue { get; set; }
    }
}
