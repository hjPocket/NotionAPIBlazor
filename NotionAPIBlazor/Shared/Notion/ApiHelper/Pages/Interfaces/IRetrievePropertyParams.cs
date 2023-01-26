
namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Pages.Interfaces
{
    public interface IRetrievePropertyParams
    {
        public int pageSize { get; set; }

        public string startCursor { get; set; }
    }
}
