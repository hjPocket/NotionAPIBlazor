
namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class StatusObject
    {
        public List<CommonObject> options { get; set; }

        public List<GroupObject> groups { get; set; }
    }

    public class GroupObject : CommonObject
    {
        public List<string> option_ids { get; set; }    }
}
