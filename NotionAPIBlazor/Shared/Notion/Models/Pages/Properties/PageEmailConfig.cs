using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageEmailConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Email;

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
