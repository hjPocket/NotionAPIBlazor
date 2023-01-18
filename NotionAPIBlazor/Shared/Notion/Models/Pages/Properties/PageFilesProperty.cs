using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageFilesProperty : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Files;

        [JsonProperty("files")]
        public FileObject Files { get; set; }
    }
}
