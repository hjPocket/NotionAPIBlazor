using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class IconProperty
    {
        public string type { get; set; }

        public string? name { get; set; }

        public string? emoji { get; set; }

        public FileObject? file { get; set; }

        public ExternalObject? external { get; set; }
    }
}
