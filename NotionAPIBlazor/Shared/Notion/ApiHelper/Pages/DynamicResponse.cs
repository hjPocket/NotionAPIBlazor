using NotionAPIBlazor.Shared.Notion.Models.Pages.PropertyItem;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class DynamicResponse
    {
        public string Type { get; set; }
        public Paginated<PropertyItem>? PaginatedItems { get; set; }
        public PropertyItem? Items { get; set; }
    }
}
