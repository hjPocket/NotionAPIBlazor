using JsonSubTypes;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public class FileObject
    {
        public string url { get; set; }

        public string expiry_time { get; set; }
    }
}
