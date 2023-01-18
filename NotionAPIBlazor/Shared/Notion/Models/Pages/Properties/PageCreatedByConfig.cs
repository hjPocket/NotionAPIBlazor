using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageCreatedByConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.CreatedBy;

        [JsonProperty("created_by")]
        public UserStruct CreatedBy { get; set; }
    }
}
