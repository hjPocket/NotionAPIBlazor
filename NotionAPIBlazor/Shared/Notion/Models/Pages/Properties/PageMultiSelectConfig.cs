using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageMultiSelectConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.MultiSelect;

        [JsonProperty("multi_select")]
        public List<MultiSelectObject> MultiSelect { get; set; }
    }

    public class MultiSelectObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("color")]
        public Color ColorColor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
