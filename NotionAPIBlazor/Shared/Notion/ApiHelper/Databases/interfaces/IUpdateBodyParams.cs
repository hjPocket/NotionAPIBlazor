using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.Databases.Properties;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases.interfaces
{
    public interface IUpdateBodyParams
    {
        public List<RichText> Title { get; set; }

        public List<RichText> Description { get; set; }

        public IDictionary<string, Property> Properties { get; set; }
    }
}
