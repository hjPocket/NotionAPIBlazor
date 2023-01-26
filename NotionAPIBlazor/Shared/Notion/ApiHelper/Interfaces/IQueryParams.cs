
namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Interfaces
{
    public interface IQueryParams
    {
        public string StartCursor { get; set; }

        public int PageSize { get; set; }
    }
}
