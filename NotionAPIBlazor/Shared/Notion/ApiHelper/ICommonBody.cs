using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper
{
    public interface ICommonBody
    {
        [JsonProperty("start_cursor")]
        public string StartCursor { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("filter_properties")]
        public string FilterProperties { get; set; }
    }
}
