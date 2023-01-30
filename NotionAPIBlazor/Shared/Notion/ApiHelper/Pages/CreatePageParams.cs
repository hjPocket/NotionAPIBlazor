
using NotionAPIBlazor.Shared.Notion.Models.Blocks;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Pages;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class CreatePageParams
    {
        public ParentObject Parent { get; set; }
        public IDictionary<string, PageProperty> Properties { get; set; }
        public List<Block>? Children { get; set; }
        public IconProperty Icon { get; set; }
        public IconProperty Cover { get; set; }
    }

    public class CreatePageType
    {
        public CreatePageParams Data { get; set; }

        public Page ReturnData { get; set; }
    }
}
