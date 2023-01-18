using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public interface IParent
    {
        [JsonConverter(typeof(StringEnumConverter))]
        ParentType Type { get; set; }
    }
}
