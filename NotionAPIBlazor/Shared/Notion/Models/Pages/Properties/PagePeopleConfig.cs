using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PagePeopleConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.People;

        [JsonProperty("people")]
        public List<UserStruct> People { get; set; }
    }
}
