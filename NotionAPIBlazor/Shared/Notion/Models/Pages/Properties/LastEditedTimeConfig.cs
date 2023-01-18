using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class LastEditedTimeConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.LastEditedTime;

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set;}
    }
}
