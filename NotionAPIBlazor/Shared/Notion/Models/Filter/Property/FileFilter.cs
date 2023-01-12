using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class FileFilter : PropertyFilter
    {
        public FileFilter(
            string propertyName,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Files = new FileCondition(is_empty, is_not_empty);
        }

        [JsonProperty("files")]
        public FileCondition Files { get; set; }
    }
}
