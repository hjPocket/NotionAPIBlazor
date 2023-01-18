using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageNumberConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Number;

        [JsonProperty("number")]
        public int Number { get; set; }
    }
}
