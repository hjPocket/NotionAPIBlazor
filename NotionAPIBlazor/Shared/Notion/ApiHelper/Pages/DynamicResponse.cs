using NotionAPIBlazor.Shared.Notion.Models.Pages.PropertyItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages
{
    public class DynamicResponse
    {
        public string Type { get; set; }
        public Paginated<PropertyItem>? PaginatedItems { get; set; }
        public PropertyItem? Items { get; set; }
    }
}
