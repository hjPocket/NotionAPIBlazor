using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.PropertyItem
{
    public class Paginated<T> : Pagination<T>
    {
        [JsonProperty("property_item")]
        public PropertyItem? PropertyItem { get; set; }

        [JsonProperty("next_url")]
        public string? NextUrl { get; set; }
    }
}
