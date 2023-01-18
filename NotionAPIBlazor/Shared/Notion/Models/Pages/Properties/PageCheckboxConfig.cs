using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageCheckboxConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Checkbox;

        [JsonProperty("checkbox")]
        public bool Checkbox { get; set; }
    }
}
