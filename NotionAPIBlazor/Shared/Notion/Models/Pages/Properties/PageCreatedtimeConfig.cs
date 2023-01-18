using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageCreatedtimeConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.CreatedTime;

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }
    }
}
