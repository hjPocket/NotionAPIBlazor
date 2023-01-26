
namespace NotionAPIBlazor.Shared.Notion.Models.User
{
    public class BotsObject
    {
        public Owner owner { get; set; }

        public string workspace_name { get; set; }
    }

    public class Owner
    {
        public string type { get; set; }
        public bool workspace { get; set; }
    }
}
