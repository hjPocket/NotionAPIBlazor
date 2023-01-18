using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageDateConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Date;

        [JsonProperty("date")]
        public DateRange Date { get; set; }
    }

    public class DateRange
    {
        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }
}
